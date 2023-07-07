using KuduoGameLb;
using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Index Example
            //// IP iP = new IP(192, 186, 1, 1);
            // IP iP = new IP("192.168.1.1");
            // var fSegment = iP[0];
            // Console.WriteLine(iP.Address());
            // Console.WriteLine(fSegment);
            // Console.ReadKey(); 
            #endregion

            #region Kuduo Example
            int[,] sudukoExample = new int[,]
                     {
                        { 3 ,1 ,6, 5, 7, 8, 4, 9, 2 },
                        { 5 ,2 ,9, 1, 3, 4, 7, 6, 8 },
                        { 3 ,1 ,6, 5, 7, 8, 4, 9, 2 },
                        { 5 ,2 ,9, 1, 3, 4, 7, 6, 8 },
                        { 3 ,1 ,6, 5, 7, 8, 4, 9, 2 },
                        { 5 ,2 ,9, 1, 3, 4, 7, 6, 8 },
                        { 3 ,1 ,6, 5, 7, 8, 4, 9, 2 },
                        { 5 ,2 ,9, 1, 3, 4, 7, 6, 8 },
                        { 3 ,1 ,6, 5, 7, 8, 4, 9, 2 }
                    };
            Kuduo kuduo = new(sudukoExample);
            Console.WriteLine(kuduo[9, 5]);
            Console.ReadKey();
            #endregion
        }
    }
    public class IP
    {
        //Index
        public int this[int index]
        {
            get
            {
                return _segments[index];
            }

            set
            {
                _segments[index] = value;
            }
        }
        private readonly int[] _segments = new int[4];
        public IP(int Segment1, int Segment2, int Segment3, int Segment4)
        {
            _segments[0] = Segment1;
            _segments[1] = Segment2;
            _segments[2] = Segment3;
            _segments[3] = Segment4;
        }
        public IP(string IPAddress)
        {
            var segs = IPAddress.Split('.');
            for (int item = 0; item < segs.Length; item++)
            {
                _segments[item] = int.Parse(segs[item]);
            }
        }
        public string Address() => String.Join('.', _segments);
    }
}
