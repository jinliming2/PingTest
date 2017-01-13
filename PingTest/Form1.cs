using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace PingTest {
    public partial class Form1 : Form {
        private delegate void AddListItem(ListViewItem item);
        private delegate void ControlDelegate(bool privilege, string tip);
        private delegate void Tip(string tip);
        private delegate string[] GetItem();
        private delegate void SetItem(int index, double ping, double TTL, string information);
        private ControlDelegate control;
        private Tip tip;
        private GetItem getItem;
        private SetItem setItem;
        private static int number;
        private static int timeout;
        private static int index = 0;
        private static bool stop = false;
        public Form1() {
            InitializeComponent();
            control = new ControlDelegate(Control);
            tip = new Tip((string t) => {
                labTip.Text = t;
                labTip.Update();
            });
            getItem = new GetItem(() => {
                if(stop || index >= lstIp.Items.Count) {
                    return null;
                }
                string[] r;
                if(lstIp.Items[index].SubItems.Count > 1) {
                    r =  new string[] {
                        index.ToString(),
                        lstIp.Items[index].SubItems[0].Text,
                        lstIp.Items[index].SubItems[1].Text
                    };
                } else {
                    r = new string[] { lstIp.Items[index].Text, "" };
                }
                ++index;
                return r;
            });
            setItem = new SetItem((int index, double ping, double TTL, string information) => {
                if(stop) {
                    return;
                }
                string info = "";
                if(lstIp.Items[index].SubItems.Count >= 5) {
                    info = lstIp.Items[index].SubItems[4].Text + " ";
                }
                info = (info + information).Trim();
                while(lstIp.Items[index].SubItems.Count > 2) {
                    lstIp.Items[index].SubItems.RemoveAt(2);
                }
                lstIp.Items[index].SubItems.Add(double.IsNaN(ping) ? "--" : Math.Round(ping, 3).ToString());
                lstIp.Items[index].SubItems.Add(double.IsNaN(TTL) ? "--" : ((int)TTL).ToString());
                lstIp.Items[index].SubItems.Add(info);
            });
        }
        private void Control(bool privilege, string tip) {
            btnAdd.Enabled = privilege;
            btnDelete.Enabled = privilege;
            btnStart.Enabled = privilege;
            txtNum.Enabled = privilege;
            txtTimeout.Enabled = privilege;
            txtThread.Enabled = privilege;
            labTip.Text = tip;
            labTip.Update();
        }
        private static string filename = ".\\ips.txt";
        private void Form1_Load(object sender, EventArgs e) {
            if(!File.Exists(filename)) {
                StreamWriter sw = File.CreateText(filename);
                sw.WriteLine("# The lines that begin with # are comments.");
                sw.WriteLine("# Input IP line by line, format: ip Comment.");
                sw.WriteLine("# Support IPv4 and IPv6, Whether or not to support ipv6 depends on your network.");
                sw.WriteLine();
                sw.WriteLine("127.0.0.1 Localhost loopback");
                sw.WriteLine("www.google.com Google, Domain name will be resolved to ip address.");
                sw.Close();
                sw.Dispose();
            }
            LoadIPs();
        }
        private void LoadIPs() {
            Control(false, "正在加载 IP 列表……");
            lstIp.Items.Clear();
            string[] ips = File.ReadAllLines(filename);
            AddListItem addListItem = new AddListItem((ListViewItem item) => {
                lstIp.Items.Add(item);
            });
            new Thread(() => {
                foreach(string line in ips) {
                    string l = line.Trim();
                    if(l.StartsWith("#")) {
                        continue;
                    }
                    string[] i = l.Split(new char[] { ' ', '\t' }, 2, StringSplitOptions.RemoveEmptyEntries);
                    if(i.Length < 1) {
                        continue;
                    }
                    IPAddress ip;
                    if(!IPAddress.TryParse(i[0], out ip)) {
                        try {
                            IPHostEntry iphe = Dns.GetHostEntry(i[0]);
                            if(iphe.AddressList.Length > 0) {
                                ip = iphe.AddressList[0];
                            } else {
                                continue;
                            }
                        } catch {
                            continue;
                        }
                    }
                    ListViewItem lvi;
                    if(i.Length > 1) {
                        lvi = new ListViewItem(new string[] { ip.ToString(), i[1] });
                    } else {
                        lvi = new ListViewItem(new string[] { ip.ToString(), "" });
                    }
                    lvi.ToolTipText = i[0];
                    lstIp.Invoke(addListItem, lvi);
                }
                Invoke(control, true, "IP 列表加载完毕！");
            }).Start();
        }
        private void btnDelete_Click(object sender, EventArgs e) {
            if(MessageBox.Show("确定删除？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK) {
                Control(false, "正在删除……");
                string[] ips = File.ReadAllLines(filename);
                string DELETE_FLAG = "----------";
                foreach(ListViewItem lvi in lstIp.SelectedItems) {
                    for(int i = 0; i < ips.Length; ++i) {
                        if(ips[i].Length > 0 && ips[i][0] != '-' && ips[i].TrimStart().StartsWith(lvi.ToolTipText)) {
                            ips[i] = DELETE_FLAG;
                        }
                    }
                    lstIp.Items.Remove(lvi);
                }
                StreamWriter sw = new StreamWriter(filename, false);
                foreach(string ip in ips) {
                    if(ip == DELETE_FLAG) {
                        continue;
                    }
                    sw.WriteLine(ip);
                }
                sw.Close();
                sw.Dispose();
                Control(true, "删除成功！");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            Form1_Load(sender, e);
        }
        private void btnStart_Click(object sender, EventArgs e) {
            stop = false;
            Control(false, "正在 Ping ……");
            number = (int)txtNum.Value;
            timeout = (int)txtTimeout.Value;
            index = 0;
            int threads = (int)txtThread.Value;
            Thread[] pool = new Thread[threads];
            for(int i = 0; i < threads; ++i) {
                pool[i] = new Thread(runTest);
                pool[i].Start();
            }
            new Thread(() => {
                for(int i = 0; i < threads; ++i) {
                    pool[i].Join();
                }
                Invoke(control, true, "所有任务完成！");
            }).Start();
        }
        private void runTest() {
            Ping ping = new Ping();
            PingReply reply;
            while(true) {
                string[] ip = Invoke(getItem) as string[];
                if(ip == null) {
                    break;
                }
                Invoke(tip, string.Format("[1]正在 Ping {0}, {1} ……", ip[1], ip[2]));
                long total = 0;
                int ttl = 0;
                int failed = 0;
                for(int j = 1; j <= number; ++j) {
                    reply = ping.Send(ip[1], timeout);
                    if(reply.Address != null) {
                        total += reply.RoundtripTime;
                        ttl += reply.Options != null ? reply.Options.Ttl : 0;
                        Invoke(tip, string.Format("[{0}]{1}ms, {2}Bytes, TTL: {3}, {4}, {5}", j, reply.RoundtripTime, reply.Buffer.Length, reply.Options != null ? reply.Options.Ttl.ToString() : "--", reply.Address, ip[2]));
                        Invoke(setItem, int.Parse(ip[0]), total / (double)(j - failed), ttl / (double)(j - failed), "");
                    } else {
                        ++failed;
                        Invoke(tip, string.Format("[{0}]{1}, {2}, {3}", j, reply.Status.ToString(), ip[1], ip[2]));
                        Invoke(setItem, int.Parse(ip[0]), total / (double)(j - failed), ttl / (double)(j - failed), reply.Status.ToString());
                    }
                }
            }
        }
    }
}
