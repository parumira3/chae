using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _chae_class
{
    class cPlayer
    {

        int iint = 2;

        public cPlayer()
        {
            //string txt = "안녕";
            iint = 3;
        }

        public int CardSum(int iSun, int iDal, int iStar)
        {
            return iSun + iDal + iStar;
        }

        public string ResultText(int iCount, int iSun, int iDal, int iStar, int icardSum)
        {
            return string.Format("{0}회 해:{1}, 달:{2}, 별:{3} => 합계는 {4}입니다", iCount, iSun, iDal, iStar, icardSum);
        }

        public string PlayerCompare(int iCount, int player1, int player2)
        {
            int iCheck = player1 - player2;
            
            if (iCheck > 0)
            {
                return string.Format("{0}회차 : 플1이 {1} 큽니다", iCount, iCheck);
            }
            else if (iCheck < 0)
            {
                return string.Format("{0}회차 : 플2이 {1} 큽니다", iCount, Math.Abs(iCheck));
            }
            else
            {
                return string.Format("{0}회차 : 비김", iCount);
            }
        }

        public string PlayerResult(int player1, int player2)
            
        {
            string strReturn = string.Empty;

            if (player1 > player2)
            {
                strReturn = "플1 이김";

            }
            else if (player1 < player2)
            {
                strReturn = "플2 이김";
            }
            else if (player1 == player2)
            {
                strReturn = "비김";

            }

            return strReturn;
        }
    }
}
