using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank_Reporter
{

    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|bank.mdb");
        private void lblinput_MouseHover(object sender, EventArgs e)
        {
            Label l1 = sender as Label;
            l1.ForeColor = Color.RoyalBlue;

        }

        private void lblinput_MouseLeave(object sender, EventArgs e)
        {
            Label l1 = sender as Label;
            l1.ForeColor = Color.Black;
        }

        private void lblinput_Click(object sender, EventArgs e)
        {
            frmperson frm1 = new frmperson();
            frm1.MdiParent = frmmdi.frmMain;
            frm1.Show();
        }

        private void lblzamen1_Click(object sender, EventArgs e)
        {

        }

        private void lblzamen2_Click(object sender, EventArgs e)
        {
            frmzamen frm1 = new frmzamen();
            frm1.MdiParent = frmmdi.frmMain;
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmperson frm1 = new frmperson();
            frm1.MdiParent = frmmdi.frmMain;
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Applicant.txtcode == null || Applicant.txtcode == "")
            {
                MessageBox.Show("لطفا مشخصات تسهیلات گیرنده را وارد سپس ضامن تعین کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmzamen frm1 = new frmzamen();
            frm1.sZamendNum = "1";
            frm1.MdiParent = frmmdi.frmMain;
            frm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Zamens.Zamen1 == true)
            {
                frmzamen frm1 = new frmzamen();
                frm1.MdiParent = frmmdi.frmMain;
                frm1.sZamendNum = "2";
                frm1.Show();
            }
            else
            {
                MessageBox.Show("اطلاعات لازم برای ضامن شماره 1 کامل نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmpreview fv1 = new frmpreview();
            fv1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zamens.Zamen1 = Zamens.Zamen2 = false;
            Zamen.txtaccountnumber1 = Zamen.txtaccounttype = Zamen.txtactiveplace = Zamen.txtactivetime = Zamen.txtactivetype = Zamen.txtaddress = Zamen.txtbirthday = Zamen.txtbirthplace = Zamen.txtcode = Zamen.txtcodeetebari = Zamen.txtcodeposti = Zamen.txtdateeftetah = Zamen.txtexpire = Zamen.txtfamily = Zamen.txtfname = Zamen.txtjob = Zamen.txtmahalekasb = Zamen.txtmojabeztype = Zamen.txtname = Zamen.txtphone = Zamen.txtphone1 = Zamen.txtphonemahalekasb = Zamen.txtsanadplace = Zamen.txtsendmojavez = Zamen.txtserish = Zamen.txtsex = Zamen.txtshohrat = Zamen.txtshomaremojavez = Zamen.txtshsh = Zamen.txtssh = Zamen.txttabeiat = Zamen.txtvakhast = "";
            Zamen2.txtaccountnumber1 = Zamen2.txtaccounttype = Zamen2.txtactiveplace = Zamen2.txtactivetime = Zamen2.txtactivetype = Zamen2.txtaddress = Zamen2.txtbirthday = Zamen2.txtbirthplace = Zamen2.txtcode = Zamen2.txtcodeetebari = Zamen2.txtcodeposti = Zamen2.txtdateeftetah = Zamen2.txtexpire = Zamen2.txtfamily = Zamen2.txtfname = Zamen2.txtjob = Zamen2.txtmahalekasb = Zamen2.txtmojabeztype = Zamen2.txtname = Zamen2.txtphone = Zamen2.txtphone1 = Zamen2.txtphonemahalekasb = Zamen2.txtsanadplace = Zamen2.txtsendmojavez = Zamen2.txtserish = Zamen2.txtsex = Zamen2.txtshohrat = Zamen2.txtshomaremojavez = Zamen2.txtshsh = Zamen2.txtssh = Zamen2.txttabeiat = Zamen2.txtvakhast = "";
            Applicant.txtaccountnumber = Applicant.txtaccountnumber1 = Applicant.txtaccounttype = Applicant.txtactiveplace = Applicant.txtactivetime = Applicant.txtactivetype = Applicant.txtaddress = Applicant.txtbirthday = Applicant.txtbirthplace = Applicant.txtchequekarmozd = Applicant.txtchequeowner = Applicant.txtchequeprice1 = Applicant.txtcity = Applicant.txtcode = Applicant.txtcodeetebari = Applicant.txtcodeposti = Applicant.txtcodesenfi = Applicant.txtdateeftetah = Applicant.txtdategharardad = Applicant.txtexpire = Applicant.txtfamily = Applicant.txtfname = Applicant.txtgharardadnumber = Applicant.txtjob = Applicant.txtmahalekasb = Applicant.txtmojabeztype = Applicant.txtname = Applicant.txtnerkh = Applicant.txtpayprice = Applicant.txtphone = Applicant.txtphone1 = Applicant.txtplacepay = Applicant.txtpricecheque = Applicant.txtsanadplace = Applicant.txtsendmojavez = Applicant.txtserish = Applicant.txtsex = Applicant.txtshobe = Applicant.txtshohrat = Applicant.txtshomaremojavez = Applicant.txtshsh = Applicant.txtssh = Applicant.txttabeiat = Applicant.txttashilatnumber = Applicant.txttashilatprice = Applicant.txttime = Applicant.txtvakhast = "";
            MessageBox.Show("تسهیلات جدید برای انجام ارائه تسهیلات انجام شد\r\nاین گزینه فقط برای پاک کردن اطلاعات قبلی که بارگذاری کرده اید است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Zamens.Zamen1 == false)
            {
                chkrezayatz1.Checked = false;
                chkvazemaliz1.Checked = false;
            }
            if (Zamens.Zamen2 == false)
            {
                chkrezayatz2.Checked = false;
                chkvazemaliz2.Checked = false;
            }
            try
            {
                db db1 = new db();
                if (Zamens.Zamen1 == true)
                {
                    if (db1.countRecord("SELECT * FROM tbl_zamens WHERE sZamenID = '" + Zamen.txtcode + "'") == 0)
                        db1.InsertRecord("INSERT INTO tbl_zamens VALUES('" + Applicant.txtcode + "','" + Zamen.txtcode + "')");
                    if (Zamens.Zamen2 == true)
                        if (db1.countRecord("SELECT * FROM tbl_zamens WHERE sZamenID = '" + Zamen2.txtcode + "'") == 0)
                            db1.InsertRecord("INSERT INTO tbl_zamens VALUES('" + Applicant.txtcode + "','" + Zamen2.txtcode + "')");
                }
            }
            catch (Exception)
            {
            }
            printClient();
            MessageBox.Show("اطلاعات با موفقیت وارد اسناد شده و اماده چاپ هستند", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printClient()
        {
            modifyWord md1 = new modifyWord();
            string[] keys = new string[115];
            string[] vals = new string[115];
            string[] filename = new string[14];
            //client information
            keys[0] = "$code";
            vals[0] = Applicant.txtcode;
            keys[1] = "$name";
            vals[1] = Applicant.txtname;
            keys[2] = "$family";
            vals[2] = Applicant.txtfamily;
            keys[3] = "$birthday";
            vals[3] = Applicant.txtbirthday;
            keys[4] = "$shsh";
            vals[4] = Applicant.txtshsh;
            keys[5] = "$fname";
            vals[5] = Applicant.txtfname;
            keys[6] = "$cp";
            vals[6] = Applicant.txtcodeposti;
            keys[7] = "$mobile";
            vals[7] = Applicant.txtphone;
            keys[8] = "$phone";
            vals[8] = Applicant.txtphone1;
            keys[9] = "$birthplace";
            vals[9] = Applicant.txtbirthplace;
            keys[10] = "$mts";
            vals[10] = Applicant.txtsanadplace;
            keys[11] = "$ssh";
            vals[11] = Applicant.txtssh;
            keys[12] = "$serish";
            vals[12] = Applicant.txtserish;
            keys[13] = "$sex";
            vals[13] = Applicant.txtsex;
            keys[14] = "$city";
            vals[14] = Applicant.txtcity;
            keys[15] = "$address";
            vals[15] = Applicant.txtaddress;
            keys[16] = "$nmf";
            vals[16] = Applicant.txtactiveplace;
            keys[17] = "$job";
            vals[17] = Applicant.txtjob;
            keys[18] = "$nf";
            vals[18] = Applicant.txtactivetype;
            keys[19] = "$mf";
            vals[19] = Applicant.txtactivetime;
            keys[20] = "$nm";
            vals[20] = Applicant.txtmojabeztype;
            keys[21] = "$ssm";
            vals[21] = Applicant.txtsendmojavez;
            keys[22] = "$v&chb";
            vals[22] = Applicant.txtvakhast;
            keys[23] = "$sh&tp";
            vals[23] = Applicant.txtshohrat;
            keys[24] = "$shsm";
            vals[24] = Applicant.txtshomaremojavez;
            keys[25] = "$dsm";
            vals[25] = Applicant.txtdatemojavez;
            keys[26] = "$tem";
            vals[26] = Applicant.txtexpire;
            keys[27] = "$tgh";
            vals[27] = Applicant.txtdategharardad;
            keys[28] = "$nh";
            vals[28] = Applicant.txtaccounttype;
            keys[29] = "$te";
            vals[29] = Applicant.txtdateeftetah;
            keys[30] = "$shh";
            vals[30] = Applicant.txtaccountnumber1;
            keys[31] = "$shgh";
            vals[31] = Applicant.txtgharardadnumber;
            keys[32] = "$sht";
            vals[32] = Applicant.txttashilatnumber;
            keys[33] = "$ce";
            vals[33] = Applicant.txtcodeetebari;
            keys[34] = "$eccs";
            vals[34] = Applicant.txtcodesenfi;
            keys[35] = "$mt";
            vals[35] = Applicant.txttashilatprice;
            keys[36] = "$nbd";
            vals[36] = Applicant.txtnerkh;
            keys[37] = "$time";
            vals[37] = Applicant.txttime;
            keys[38] = "$mv";
            vals[38] = Applicant.txtpayprice;
            keys[39] = "$tabeiat";
            vals[39] = Applicant.txttabeiat;
            keys[40] = "$ngch";
            vals[40] = Applicant.txtchequeowner;
            keys[41] = "$mpchb";
            vals[41] = Applicant.txtplacepay;
            keys[42] = "$nsf";
            vals[42] = Applicant.txtaccountnumber;
            keys[43] = "$mch";
            vals[43] = Applicant.txtpricecheque;
            keys[44] = "$mchh";
            vals[44] = Applicant.txtchequeprice1;
            keys[45] = "$shobe";
            vals[45] = Applicant.txtshobe;
            keys[46] = "$karmozd";
            vals[46] = Applicant.txtchequekarmozd;
            keys[47] = "$total";
            try
            {
                vals[47] = (Convert.ToDouble(Applicant.txtchequekarmozd) + Convert.ToDouble(Applicant.txtpricecheque)).ToString();
            }
            catch (Exception)
            {
                vals[47] = "0";
            }
            keys[48] = "$mmk";
            vals[48] = Applicant.txtmahalekasb;
            ////////////////////////////
            ///////zamen 1
            keys[49] = "$c1ode1";
            vals[49] = Zamen.txtcode;
            keys[50] = "$n1ame1";
            vals[50] = Zamen.txtname;
            keys[51] = "$f1amily1";
            vals[51] = Zamen.txtfamily;
            keys[52] = "$b1irthday1";
            vals[52] = Zamen.txtbirthday;
            keys[53] = "$s1hsh1";
            vals[53] = Zamen.txtshsh;
            keys[54] = "$f1name1";
            vals[54] = Zamen.txtfname;
            keys[55] = "$c1odeposti1";
            vals[55] = Zamen.txtcodeposti;
            keys[56] = "$m1obile1";
            vals[56] = Zamen.txtphone;
            keys[57] = "$p1hone1";
            vals[57] = Zamen.txtphone1;
            keys[58] = "$b1irthplace1";
            vals[58] = Zamen.txtbirthplace;
            keys[59] = "$m1ts1";
            vals[59] = Zamen.txtsanadplace;
            keys[60] = "$s1erialsh1";
            vals[60] = Zamen.txtssh;
            keys[61] = "$s1erish1";
            vals[61] = Zamen.txtserish;
            keys[62] = "$s1ex1";
            vals[62] = Zamen.txtsex;
            keys[63] = "$c1e1";
            vals[63] = Zamen.txtcodeetebari;
            keys[64] = "$a1ddress1";
            vals[64] = Zamen.txtaddress;
            keys[65] = "$n1mf1";
            vals[65] = Zamen.txtactiveplace;
            keys[66] = "$j1ob1";
            vals[66] = Zamen.txtjob;
            keys[67] = "$n1f1";
            vals[67] = Zamen.txtactivetype;
            keys[68] = "$m1f1";
            vals[68] = Zamen.txtactivetime;
            keys[69] = "$n1m1";
            vals[69] = Zamen.txtmojabeztype;
            keys[70] = "$s1dm1";
            vals[70] = Zamen.txtsendmojavez;
            keys[71] = "$v1&chb1";
            vals[71] = Zamen.txtvakhast;
            keys[72] = "$s1h&tp1";
            vals[72] = Zamen.txtshohrat;
            keys[73] = "$s1hsm1";
            vals[73] = Zamen.txtshomaremojavez;
            keys[74] = "$d1sm1";
            vals[74] = Zamen.txtdatemojavez;
            keys[75] = "$e1xpire1";
            vals[75] = Zamen.txtexpire;
            keys[76] = "$t1e1";
            vals[76] = Zamen.txtdateeftetah;
            keys[77] = "$s1hh1";
            vals[77] = Zamen.txtaccountnumber1;
            keys[78] = "$p1honemahal1";
            vals[78] = Zamen.txtphonemahalekasb;
            keys[79] = "$n1h1";
            vals[79] = Zamen.txtaccounttype;
            //zamen 2
            keys[80] = "$c2ode2";
            vals[80] = Zamen2.txtcode;
            keys[81] = "$n2ame2";
            vals[81] = Zamen2.txtname;
            keys[82] = "$f2amily2";
            vals[82] = Zamen2.txtfamily;
            keys[83] = "$b2irthday2";
            vals[83] = Zamen2.txtbirthday;
            keys[84] = "$s2hsh2";
            vals[84] = Zamen2.txtshsh;
            keys[85] = "$f2name2";
            vals[85] = Zamen2.txtfname;
            keys[86] = "$c2odeposti2";
            vals[86] = Zamen2.txtcodeposti;
            keys[87] = "$m2obile2";
            vals[87] = Zamen2.txtphone;
            keys[88] = "$p2hone2";
            vals[88] = Zamen2.txtphone1;
            keys[89] = "$b2irthplace2";
            vals[89] = Zamen2.txtbirthplace;
            keys[90] = "$m2ts2";
            vals[90] = Zamen2.txtsanadplace;
            keys[91] = "$s2erialsh2";
            vals[91] = Zamen2.txtssh;
            keys[92] = "$s2erish2";
            vals[92] = Zamen2.txtserish;
            keys[93] = "$s2ex2";
            vals[93] = Zamen2.txtsex;
            keys[94] = "$c2e2";
            vals[94] = Zamen2.txtcodeetebari;
            keys[95] = "$a2ddress2";
            vals[95] = Zamen2.txtaddress;
            keys[96] = "$n2mf2";
            vals[96] = Zamen2.txtactiveplace;
            keys[97] = "$j2ob2";
            vals[97] = Zamen2.txtjob;
            keys[98] = "$n2f2";
            vals[98] = Zamen2.txtactivetype;
            keys[99] = "$m2f2";
            vals[99] = Zamen2.txtactivetime;
            keys[100] = "$n2m2";
            vals[100] = Zamen2.txtmojabeztype;
            keys[101] = "$s2dm2";
            vals[101] = Zamen2.txtsendmojavez;
            keys[102] = "$v2&chb2";
            vals[102] = Zamen2.txtvakhast;
            keys[103] = "$s2h&tp2";
            vals[103] = Zamen2.txtshohrat;
            keys[104] = "$s2hsm2";
            vals[104] = Zamen2.txtshomaremojavez;
            keys[105] = "$d2sm2";
            vals[105] = Zamen2.txtdatemojavez;
            keys[106] = "$e2xpire2";
            vals[106] = Zamen2.txtexpire;
            keys[107] = "$t2e2";
            vals[107] = Zamen2.txtdateeftetah;
            keys[108] = "$s2hh2";
            vals[108] = Zamen2.txtaccountnumber1;
            keys[109] = "$p2honemahal2";
            vals[109] = Zamen2.txtphonemahalekasb;
            keys[110] = "$n2h2";
            vals[110] = Zamen2.txtaccounttype;
            keys[111] = "$t1gh1";
            vals[111] = db.getDate();
            keys[112] = "$t2gh2";
            vals[112] = db.getDate();
            keys[113] = "$t2abeiat";
            vals[113] = Zamen2.txttabeiat;
            keys[114] = "$t2abeiat1";
            vals[114] = Zamen.txttabeiat;

            //filename document
            filename[0] = "zamen.doc";
            filename[1] = "client.doc";
            filename[2] = "bdt.doc"; //برگه درخواست تسهیلات

            if (chkcheque.Checked == true)
                filename[3] = "fdch.doc"; //فرم درخواست چک
            else
                filename[3] = ""; //فرم درخواست چک

            if (chkkomision.Checked == true)
                filename[4] = "fk.doc";  //فرم کمیسیون
            else
                filename[4] = "";  //فرم کمیسیون

            if (chkmotammam.Checked == true)
                filename[5] = "mgd.doc"; //متمم قرارداد داخلی
            else
                filename[5] = ""; //متمم قرارداد داخلی

            if (chkvazemali.Checked == true)
                filename[6] = "mvsclient.doc"; //محرمانه،وضع مالی و شهرت پرداخت شریک یا عامل
            else
                filename[6] = "";

            if (chkmotammam.Checked == true)
                filename[7] = "resclient.doc";  //فرم رضایت نامه
            else
                filename[7] = "";

            if (chktaahod.Checked == true)
                filename[8] = "t&p.doc"; //تعهدنامه
            else
                filename[8] = "";

            //Fill Zamen 1 Data
            if (chkrezayatz1.Checked == true)
                filename[9] = "resz1.doc";  //فرم رضایت نامه
            else
                filename[9] = "";

            if (chkvazemaliz1.Checked == true)
                filename[10] = "mvsz1.doc"; //محرمانه،وضع مالی و شهرت پرداخت
            else
                filename[10] = "";

            ////////////
            //Fill Zamen 2 Data
            if (Zamens.Zamen2 == true)
            {
                if (chkrezayatz2.Checked == true)
                    filename[12] = "resz2.doc";  //فرم رضایت نامه
                else
                    filename[12] = "";

                if (chkvazemaliz2.Checked == true)
                    filename[13] = "mvsz2.doc"; //محرمانه،وضع مالی و شهرت پرداخت
                else
                    filename[13] = "";
            }
            ////////////
            MessageBox.Show("پردازش اطلاعات و چاپ آن ها کمی طول میکشد\r\nو در صورت موفقیت پیامی اعلام میشود", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            md1.OpenWord(Application.StartupPath, filename, keys, vals);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
