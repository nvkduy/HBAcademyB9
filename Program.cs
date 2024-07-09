using System;
using System.Collections.Generic;
using System.Text;

namespace HBAcademyB9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập encoding để hỗ trợ Unicode cho Console
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Nhập số lượng phần tử của mảng từ người dùng
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());

            // Khởi tạo mảng numbers có kích thước n để lưu các phần tử nhập vào
            int[] numbers = new int[n];

            // Nhập từng phần tử của mảng từ người dùng
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Tìm và in ra số nhỏ nhất trong mảng
            int min = FindMin(numbers);
            Console.WriteLine("Số nhỏ nhất là: " + min);

            // Tìm và in ra số lớn nhất trong mảng
            int max = FindMax(numbers);
            Console.WriteLine("Số lớn nhất là: " + max);

            // Tìm và in ra các số chẵn trong mảng
            List<int> chanNumbers = FindChans(numbers);
            if (chanNumbers.Count > 0)
            {
                Console.WriteLine("Số chẵn là: " + string.Join(",", chanNumbers));
            }
            else
            {
                Console.WriteLine("Không có số chẵn");
            }

            // Tìm và in ra các số lẻ trong mảng
            List<int> leNumbers = FindLes(numbers);
            if (leNumbers.Count > 0)
            {
                Console.WriteLine("Số lẻ là: " + string.Join(",", leNumbers));
            }
            else
            {
                Console.WriteLine("Không có số lẻ");
            }           
            // Gọi hàm để nhập và in dữ liệu
            string duLieuNhap = NhapDuLieu();
            InDuLieu(duLieuNhap);
            Console.ReadKey();
        }

        // Hàm tìm số nhỏ nhất trong mảng numbers
        static int FindMin(int[] numbers)
        {
            int min = numbers[0]; // Giả sử phần tử đầu tiên là nhỏ nhất

            // Duyệt qua từng phần tử của mảng để tìm số nhỏ nhất
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num; // Cập nhật min nếu tìm thấy số nhỏ hơn
                }
            }

            return min; // Trả về số nhỏ nhất
        }

        // Hàm tìm số lớn nhất trong mảng numbers
        static int FindMax(int[] numbers)
        {
            int max = numbers[0]; // Giả sử phần tử đầu tiên là lớn nhất

            // Duyệt qua từng phần tử của mảng để tìm số lớn nhất
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num; // Cập nhật max nếu tìm thấy số lớn hơn
                }
            }

            return max; // Trả về số lớn nhất
        }

        // Hàm tìm các số chẵn trong mảng numbers
        static List<int> FindChans(int[] numbers)
        {
            List<int> chanNumbers = new List<int>();

            // Duyệt qua từng phần tử của mảng để tìm các số chẵn và thêm vào danh sách chanNumbers
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    chanNumbers.Add(num);
                }
            }

            return chanNumbers; // Trả về danh sách các số chẵn
        }

        // Hàm tìm các số lẻ trong mảng numbers
        static List<int> FindLes(int[] numbers)
        {
            List<int> leNumbers = new List<int>();

            // Duyệt qua từng phần tử của mảng để tìm các số lẻ và thêm vào danh sách leNumbers
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    leNumbers.Add(num);
                }
            }

            return leNumbers; // Trả về danh sách các số lẻ
        }
        static string NhapDuLieu()
        {
            // Hàm nhập dữ liệu từ người dùng và trả về dữ liệu đã nhập
            Console.Write("Nhập dữ liệu: ");
            string duLieu = Console.ReadLine();
            return duLieu;
        }

        static void InDuLieu(string duLieu)
        {
            // Hàm in dữ liệu đã nhập
            Console.WriteLine($"Dữ liệu đã nhập: {duLieu}");
        }
        static void chuanHoa()
        {
            String name = new String("  NguyEn  VaN huNg  ");
            char[] charArray = name.ToCharArray();
            char[] newChar = new char[charArray.Length];
            int newIndex = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] >= 'A' && charArray[i] <= 'Z')
                {
                    charArray[i] = (char)(charArray[i]+32);
                }
            }
        }
    }
}
