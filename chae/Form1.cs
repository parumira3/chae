using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CPL = _chae_class;

namespace chae
{

    struct structPlayer
    {
        public int iCount;

        public int iSun;
        public int iDal;
        public int iStar;

        public int icardSum;

    }



    public partial class Form1 : Form
    {

        structPlayer _stPlayer1;
        structPlayer _stPlayer2;

        Random _rd = new Random();

        CPL.cPlayer _clPlayer;  // = new CPL.cPlayer();


        //CP _clPlayer1 = new CP();
        //_chae_class.cPlayer _clPlayer2 = new _chae_class.cPlayer();


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
                strResult = _clPlayer.ResultText(_stPlayer1.iCount, _stPlayer1.iSun, _stPlayer1.iDal, _stPlayer1.iStar, _stPlayer1.icardSum);
                listResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;
                strResult = _clPlayer.ResultText(_stPlayer2.iCount, _stPlayer2.iSun, _stPlayer2.iDal, _stPlayer2.iStar, _stPlayer2.icardSum);
                listResult2.Items.Add(strResult);
            }
            iCheckedChange();
           // Finaltext();
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

        //private void Finaltext()
        //{

        //    if (_stPlayer1.iCount == 5 & _stPlayer2.iCount == 5)
        //    {
        //        if (_stPlayer1.icardSum > _stPlayer2.icardSum)
        //        {
        //            MessageBox.Show("플레이어1");
        //        }
        //        else if (_clPlayer1.icardSum < _clPlayer2.icardSum)
        //        {
        //            MessageBox.Show("플레이어2");
        //        }
        //        else if (_clPlayer1.icardSum == _clPlayer2.icardSum)
        //        {
        //            MessageBox.Show("==");
        //        }

        //    }
        //}

        //CP _clPlayer1 = new CP();
        //_chae_class.cPlayer _clPlayer2 = new _chae_class.cPlayer();

        private void Result()
        {
            string strResult = string.Empty;

            _clPlayer  = new CPL.cPlayer();

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;
                _stPlayer1.icardSum =  _clPlayer.CardSum(_stPlayer1.iSun, _stPlayer1.iDal, _stPlayer1.iStar);
                strResult = _clPlayer.ResultText(_stPlayer1.iCount,_stPlayer1.iSun, _stPlayer1.iDal, _stPlayer1.iStar, _stPlayer1.icardSum);
                listResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;
                _stPlayer2.icardSum = _clPlayer.CardSum(_stPlayer2.iSun, _stPlayer2.iDal, _stPlayer2.iStar);
                strResult = _clPlayer.ResultText(_stPlayer2.iCount, _stPlayer2.iSun, _stPlayer2.iDal, _stPlayer2.iStar, _stPlayer2.icardSum);
                listResult2.Items.Add(strResult);

            }

            iCheckedChange();

            if (_stPlayer1.iCount == _stPlayer2.iCount)
            {
                listSang.Items.Add(_clPlayer.PlayerCompare(_stPlayer2.iCount, _stPlayer1.icardSum, _stPlayer2.icardSum));

                if (_stPlayer2.iCount >= 5)
                {
                    listSang.Items.Add(_clPlayer.PlayerResult(_stPlayer1.icardSum, _stPlayer2.icardSum));
                }
            }
            //Finaltext();

        }
    }
}
