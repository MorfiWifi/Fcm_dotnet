using FCM_notifyer.mdoels;
using FCM_notifyer.network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCM_notifyer
{
    public partial class Form1 : Form
    {
        bool isExpended = false;
        TabPage current_tab;
        static string[] TAB_NAMES =  {"tab_SimpleNotif" , "tab_Data" };


        public Form1()
        {
            InitializeComponent();
            // auto colpse start
            Width = 822;
            groupBox1.Visible = false;
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
            current_tab = (tabControl1).SelectedTab;
        }

        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            current_tab = (sender as TabControl).SelectedTab;
            Console.WriteLine("current tab : " + current_tab.Name);
            //current tab : tab_Data
            //current tab: tab_SimpleNotif
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            toggle_expan();
        }

        private void toggle_expan()
        {
            if (isExpended)
            {
                groupBox1.Visible = false;
                this.Width = 822;
            }
            else
            {
                groupBox1.Visible = true;
                this.Width = 1300;
            }
            isExpended = !isExpended;
        }

        private async void Button1_Click(object sender, EventArgs e)
        {// send btn
            Data data = new Data();
            data.key = "key=" + txbox_key.Text;
            data.to = txbox_to.Text;
            if (current_tab.Name.Equals(TAB_NAMES[0]))
            {//simple notif
                data.build_notif(txbox_title.Text, txbox_body.Text);
                data.print();
            }
            else
            {//data message[comp]
                data.build_data(richbox_data.Text);
                data.print();
            }

            var res = await RequestHandler.post_notif(data, data.key);
            richbox_res.Text = res;
        }


        
    }
}
