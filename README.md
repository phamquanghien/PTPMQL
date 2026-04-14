Học phần Phát triển phần mềm quản lý
1. Nội dung học
    - Phát triển website giải quyết một bài toán trên thực tế theo kiến trúc .Net MVC
    - .Net C#, Git, Github
    - Công nghệ: .Net Core C#, Code First, Entity Framework
    - Kiến trúc phát triển website: MVC (Model View Controller)
    - Đánh giá kết quả học phần
        + Điểm C: Điểm danh + Làm bài thực hành
        + Điểm B: Bài kiểm tra
        + Điểm A: Làm bài thi (Thực hành + Vấn đáp)
2. Thiết lập môi trường lập trình
    - .Net 10.0: https://dotnet.microsoft.com/en-us/download
    - Git: https://git-scm.com/install/
    - Github: https://github.com/
    - Visual Studio Code: https://code.visualstudio.com/
    - Dbeaver: https://dbeaver.io/
    - Extensions for VS Code: C# Dev Kit, C#, IntelliCode for C# Dev Kit, C# Snippets, C# Namespace Autocompletion, Auto Close Tag, Auto Complete Tag, Auto Rename Tag
3. Tài liệu môn học
    - Slide bài giảng: https://drive.google.com/drive/folders/1HQXd0UEd4v293ILj8vrp7ziWy4oBmM7E?usp=sharing
    - Tài liệu của microsoft: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-10.0&tabs=visual-studio-code
4. Buổi học số 3
   - Tạo project với lệnh "dotnet new..." sau đó đẩy lên github
   - Tìm hiểu cấu trúc thư mục của dự án .Net MVC => Trình bày trong file README.md
   - Tìm hiểu về định tuyến (Route) trong .Net MVC => trình bày trong file README.md
   - Tìm hiểu về namespace trong C#
   - Tìm hiểu về Controller, View trong .Net MVC => trình bày trong file README.md
   - Tạo DemoController và View Index trả về thông báo "Hello + Họ tên và mã sinh viên"
   - Đẩy mã nguồn lên github với commit "BaiThucHanhSo3"
5. Buổi học số 4
   - Tìm hiểu về ViewBag trong MVC
   - Lấy ví dụ sử dụng ViewBag để gửi dữ liệu từ Controller về View
   - Tìm hiểu về gửi nhận dữ liệu giữa View và Controller thông qua Submit form.
   - Lấy ví dụ: nhập họ tên trên view gửi dữ liệu lên controller, controller xử lý và gửi thông báo "Xin chào " + Họ tên về hiển thị lên view.
   - Tìm hiểu về Models, tạo class Student có 2 thuộc tính: StudentCode, FullName
   - Xây dựng chức năng gửi nhận dữ liệu kiểu Student giữa View và Controller (StudentController).
   - Tìm hiểu về Layout, bổ sung thêm điều hướng tới StudentController
   - Đẩy mã nguồn lên github với commit "BaiThucHanhSo4"
6. Buổi học số 5: Kết nối với cơ sở dữ liệu
   - Cài đặt tool hỗ trợ quản lý phiên bản CSDL (Migrations), tool hỗ trợ sinh mã nguồn
   - Cài đặt các package (các gói hỗ trợ để kết nối và làm việc với cơ sở dữ liệu)
   - Tạo file Data/ApplicationDbContext.cs
   - Cấu hình ở file appsettings.json
   - Cấu hình ở file Program.cs
   - Khai báo DbSet trong ApplicationDbContext.cs
   - Sử dụng Migrations để tạo cơ sở dữ liệu
7. Buổi học số 6: Xây dựng chức năng CRUD (Create, Read, Update, Delete)
   - Tạo class trong model => sử dụng migrations để tạo ra các bảng tương ứng
   - Xây dựng chức năng hiển thị dữ liệu:
        + Tạo controller => tạo action lấy dữ liệu từ CSDL (sử dụng dbContext)
        + Trả dữ liệu về view
        + Tạo view => Hiển thị dữ liệu
    - Xây dựng chức năng thêm mới dữ liệu (Create)
        + Tạo action trả view cho phép nhập dữ liệu
        + Tạo view cho phép nhập dữ liệu
        + Submit form để gửi dữ liệu từ view => controller
        + Controller nhận dữ liệu và lưu vào trong CSDL
    - Xây dựng chức năng chỉnh sửa dữ liệu (Update)
        + Tạo action lấy dữ liệu của bản ghi muốn sửa => trả dữ liệu về View
        + Tạo view Edit để hiển thị dữ liệu bản ghi muốn chỉnh sửa
        + Nhận dữ liệu từ view gửi lên và tiến hành lưu vào CSDL
    - Xây dựng chức năng chỉnh xoá dữ liệu (Delete)
        + Tạo action lấy dữ liệu của bản ghi muốn xoá => trả dữ liệu về View
        + Hiển thị form xác nhận có đồng ý xoá hay không
        + Huỷ không xoá/Xác nhận xoá => Submit for delete => Xoá bỏ khỏi dbContext => Lưu thay đổi vào CSDL
8. Buổi học số 7: CRUD (Tiếp tục)
    - Sử dụng Data Annotation trong kiểm tra (validation) dữ liệu đầu vào
        + Namespace: System.ComponentModel.DataAnnotations
        + Sử dụng các thuộc tính (attribute) như: Required, Range, EmailAddress, StringLength... => validate dữ liệu ở model
        + Validate dữ liệu ở view: asp-validation-for 
        + Validate dữ liệu ở controller: if(ModelState.IsValid)
    - Tạo trang NotFound để xử lý khi không tìm thấy dữ liệu
9.  Buổi học số 8:
    - Liên kết khoá ngoại trong code first
    - LinQ
    - ViewModel để hiển thị dữ liệu giữa nhiều bảng
10. Buổi học số 9: Ôn tập các nội dung
    - Tạo class
    - Sử dụng migrations
    - Tạo liên kết khoá ngoại
    - Sử dụng ViewModel
    - Làm bài thực hành Buổi 9
11. Bài thực hành
    - Bài thực hành Buổi 1:
        + Bài thực hành số 1: Cài đặt môi trường, Tạo repository trên github, chèn link github vào link thông tin môn học (Sheet DanhSachLop), deadline: 08/01/2026
        + Bài thực hành số 2: Làm bài thực hành phần HTML (https://www.w3schools.com/html/default.asp) hết phần Form, deadline: 13/01/2026
        + Bài thực hành số 2: Làm bài thực hành phần CSS (https://www.w3schools.com/bootstrap5/index.php) hết phần Form, deadline: 20/01/2026
    - Bài thực hành Buổi 6: Xây dựng chức năng CRUD với đối tượng Student
    - Bài thực hành Buổi 7: Hoàn thiện chức năng CRUD có validate dữ liệu với đối tượng Student
    - Bài thực hành Buổi 8:
        + Tạo class Faculty và Student (nếu chưa có), tạo liên kết khoá ngoại thông qua FacultyID (một khoa có nhiều sinh viên, một sinh viên chỉ thuộc một khoa)
        + Tạo ViewModel để hiển thị dữ liệu sinh viên và khoa bao gồm: Mã sinh viên, họ tên, Khoa
    - Bài thực hành Buổi 9: Tạo class: Khách hàng, Đơn hàng, Chi tiết đơn hàng, Sản phẩm với yêu cầu:
        + Một khách hàng có nhiều đơn hàng
        + Một đơn hàng thuộc 1 khách hàng
        + Một đơn hàng có nhiều sản phẩm lưu ở chi tiết đơn hàng
        + Ràng buộc dữ liệu các thuộc tính trên model
        + Xây dựng chức năng CRUD với các bảng dữ liệu trên
        + Xây dựng chức năng cho phép xem thông tin chi tiết các đơn hàng mà một khác hàng đã mua.