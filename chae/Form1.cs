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

            Result();
            
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

            Result();
        }

        private void pictNone_Click(object sender, EventArgs e)
        {
            string strResult = string.Empty;

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;
                strResult = _stPlayer1.ResultText();
                listResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;
                strResult = _stPlayer2.ResultText();
                listResult2.Items.Add(strResult);
            }
            iCheckedChange();
            Finaltext();
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

        private void Finaltext()
        {

            if (_stPlayer1.iCount == 5 & _stPlayer2.iCount == 5)
            {
                if (_stPlayer1.icardSum > _stPlayer2.icardSum)
                {
                    MessageBox.Show("플레이어1");
                }
                else if (_stPlayer1.icardSum < _stPlayer2.icardSum)
                {
                    MessageBox.Show("플레이어2");
                }
                else if (_stPlayer1.icardSum == _stPlayer2.icardSum)
                {
                    MessageBox.Show("==");
                }

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
                listResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;
                _stPlayer2.icardSum = _stPlayer2.CardSum(_stPlayer2.iSun, _stPlayer2.iDal, _stPlayer2.iStar);
                strResult = _stPlayer2.ResultText();
                listResult2.Items.Add(strResult);

            }

            iCheckedChange();
            Finaltext();

            //if (_stPlayer1.iCount >=5 && _stPlayer2.iCount >= 5)
            //{
            //    if (_stPlayer1.icardSum > _stPlayer2.icardSum)
            //    {
            //        MessageBox.Show("플레이어1");
            //    }
            //    else if (_stPlayer1.icardSum < _stPlayer2.icardSum)
            //    {
            //        MessageBox.Show("플레이어2");
            //    }
            //    else
            //    {
            //        MessageBox.Show("==");
            //    }

            //}

        }
    }
}
