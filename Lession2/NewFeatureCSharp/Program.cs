using System;

namespace NewFeatureCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CÁC TÍNH NĂNG MỚI TRONG C#
            //1.String interpolation
            string hoTen = "Nguyen Van An";
            int tuoi = 20;
            //C# 5.0
            Console.WriteLine("Chao ban {0}, ban nam nay {1} tuoi",hoTen,tuoi);
            //Từ C# 6.0
            Console.WriteLine($"Chao ban {hoTen}, ban nam nay {tuoi} tuoi");

            //2.Thuộc tính tự động
            //3.Cung cấp giá trị cho các thuộc tính khi khởi tạo đối tượng
            //- Thông thường muốn khởi tạo giá trị cho thuộc tính ta dùng PHƯƠNG THỨC KHỞI TẠO
            //- Ngoài ra có thể sử dụng cách sau:
            var student = new Student()
            {
                StudentId = "1351001002",
                StudentName = "Tran Vu Dai"
            };
            //4.Tự nhận biết kiểu dữ liệu khi gán dữ liệu cho biến
            //- Trước kia khi khai báo biến thì cần xác định kiểu dữ liệu của biến
            int x = 4;
            //- Có thể khai báo như sau sử dụng từ khóa var:
            var a = 5;
            var b = 7.5;

            //5.Kiểu nặc danh
            //- Trước kia để tạo một đối tượng thì phải cần định nghĩa 1 lớp
            //- Kiểu nặc danh: cho phép tạo đối tượng mà không cần định nghĩa lớp
            var customer = new
            {
                CustomerId = "KH01",
                CustomerName = "Nguyen Van Son",
                Address = "Ha Noi"
            };
            Console.WriteLine($"{customer.CustomerName}, dia chi {customer.Address}");
            //6.Kiểu động (dynamic)
        }
    }
    class Student
    {
        //private string studentId;
        //public string StudentId
        //{
        //    get { return studentId; }
        //    set { studentId = value; }
        //}
        //Có thể viết lại như sau
        public string StudentId { get; set; }//tự sinh biến thành viên để lưu dữ liệu của thuộc tính
        public string StudentName { get; set; }
    }
}
