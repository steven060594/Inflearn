using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SJ.Inflearn
{
    public class BigOBehaviour : MonoBehaviour
    {

        /*
         * 수행되는 연산(산술, 비교 대입 등)의 개수를 '대략적으로' 판단
         */
        #region BIG-O 표기법 1단계 : 대략적인 계산

        //1회
        private int Add(int n)
        {
            return n + n;
        }

        //N + 1회
        private int Add2(int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += i;
            }

            return sum;
        }

        //N^2 + 1회
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
         * 1. 영향력이 가장 큰 대표 항목만 남기고 삭제
         * 2. 상수 무시 (ex. 2N => N)
         */
        #region BIG-O 표기법 2단계 : 대장만 남긴다

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
