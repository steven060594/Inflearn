using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SJ.Inflearn
{
    public class BigOBehaviour : MonoBehaviour
    {

        /*
         * ����Ǵ� ����(���, �� ���� ��)�� ������ '�뷫������' �Ǵ�
         */
        #region BIG-O ǥ��� 1�ܰ� : �뷫���� ���

        //1ȸ
        private int Add(int n)
        {
            return n + n;
        }

        //N + 1ȸ
        private int Add2(int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += i;
            }

            return sum;
        }

        //N^2 + 1ȸ
        private int Add3(int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += j;
                }
            }

            return sum;
        }

        #endregion

        /*
         * 1. ������� ���� ū ��ǥ �׸� ����� ����
         * 2. ��� ���� (ex. 2N => N)
         */
        #region BIG-O ǥ��� 2�ܰ� : ���常 �����

        /// <summary>
        /// O(1 + N + 4*N^2 + 1)
        /// == O(4*N^2)
        /// == O(N^2)
        /// </summary>
        private int Add4(int n)
        {
            int sum = 0;

            for(int i=0; i<n; i++)
            {
                sum += i;
            }

            for(int i=0; i<2*n; i++)
            {
                for(int j=0; j<2*n; j++)
                {
                    sum += 1;
                }
            }

            sum += 1234567;

            return sum;
        }

        #endregion
    }
}
