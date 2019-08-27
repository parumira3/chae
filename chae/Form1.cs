using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chae
{
    public partial class Form1 : Form
    {
        struct structPlayer
        {
            public int iCount;

            public int iSun;
            public int iDal;
            public int iStar;

            public int icardSum;

            public int CardSum(int iSun, int iDal, int iStar)
            {
                return iSun + iDal + iStar;
            }

            public string ResultText()
            {
                return string.Format("{0}회 해:{1}, 달:{2}, 별:{3} => 합계는 {4}입니다", iCount, iSun, iDal, iStar, icardSum);
            }


        }

        //class classPlayer
        //{
        //    public int iCount = 0;

        //    public int iSun;
        //    public int iDal;
        //    public int iStar;

        //    public int icardSum;

        //    public int CardSum(int iSun, int iDal, int iStar)
        //    {
        //        return iSun + iDal + iStar;
        //    }

        //    public string ResultText()
        //    {
        //        return string.Format("{0}회 해:{1}, 달:{2}, 별:{3} => 합계는 {4}입니다", iCount, iSun, iDal, iStar, icardSum);
        //    }

        //}

        structPlayer _stPlayer1;
        structPlayer _stPlayer2;

        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }





        private void pictHae_Click(object sender, EventArgs e)
        {
                        
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }

            Result();
            iCheckedChange();

        }

        private void pictDal_Click(object sender, EventArgs e)
        {

            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iDal = iNumber;
            }
            else
            {
                _stPlayer2.iDal = iNumber;
            }
            iCheckedChange();

        }

        private void pictStar_Click(object sender, EventArgs e)
        {

            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }
            iCheckedChange();
        }

        private void pictNone_Click(object sender, EventArgs e)
        {
            iCheckedChange();
        }

        private void iCheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }

        private void Result()
        {
            string strResult = string.Empty;

            int iCardSum = 0;

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;
                _stPlayer1.icardSum =  _stPlayer1.CardSum(_stPlayer1.iSun, _stPlayer1.iDal, _stPlayer1.iStar);
                strResult = _stPlayer1.ResultText();
            }
        }
    }
}
