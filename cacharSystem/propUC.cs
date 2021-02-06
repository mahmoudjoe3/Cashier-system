using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cacharSystem
{
    public partial class propUC : UserControl
    {
        public propUC()
        {
            InitializeComponent();
            initUi();
        }

        private void initUi()
        {
            String date = getDate();
            String day = date.Split(' ')[0].ToLower();
            String month= date.Split(' ')[1].Split(',')[0].ToLower();
            switch (day)
            {
                case "sat":
                    prop_w_sat.ForeColor = System.Drawing.Color.Green;
                    break;
                case "san":
                    prop_w_sun.ForeColor = System.Drawing.Color.Green;
                    break;
                case "mon":
                    prop_w_mon.ForeColor = System.Drawing.Color.Green;
                    break;
                case "tue":
                    prop_w_tue.ForeColor = System.Drawing.Color.Green;
                    break;
                case "wed":
                    prop_w_wed.ForeColor = System.Drawing.Color.Green;
                    break;
                case "the":
                    prop_w_thu.ForeColor = System.Drawing.Color.Green;
                    break;
                case "fri":
                    prop_w_fri.ForeColor = System.Drawing.Color.Green;
                    break;
            }

            switch (month)
            {
                case "jan":
                    prop_bar_m_jan.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_jan.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "feb":
                    prop_bar_m_feb.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_feb.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "mar":
                    prop_bar_m_mar.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_mar.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "apr":
                    prop_bar_m_apr.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_apr.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "may":
                    prop_bar_m_may.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_may.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "jun":
                    prop_bar_m_jun.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_jun.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "jul":
                    prop_bar_m_jul.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_jul.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "aug":
                    prop_bar_m_aug.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_aug.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "sep":
                    prop_bar_m_sep.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_sep.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "oct":
                    prop_bar_m_oct.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_oct.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "nov":
                    prop_bar_m_nov.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_nov.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
                case "dec":
                    prop_bar_m_dec.ProgressColor = System.Drawing.Color.LawnGreen;
                    prop_bar_m_dec.ProgressColor2 = System.Drawing.Color.LawnGreen;
                    break;
            }
        }

        private String getDate()
        {
            return DateTime.Now.ToString("ddd MMM,dd,yyyy");
        }
    }
}
