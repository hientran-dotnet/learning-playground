PHẦN 1 - OOP (LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG)

I. Lý thuyết

1. Class & Object

- Class: Bản vẽ thiết kế/ bản vẽ mô tả thuộc tính và hành vi của một đối tượng
  VD: Bản vẽ thiết kế của một chiếc ô tô mang các thuộc tính như: màu sắc, thông số bánh xe, dung tích xi lanh,...
  Và hành vi của chiếc xe như: nổ máy, di chuyển, thắng, ...
- Object: Một thực thể được tạo ra từ class
  VD: Một chiếc ô tô được tạo ra từ một bản vẽ thiết kế
  Xe ô tô honda civic màu đỏ, dung tích xi lanh 1.8L có thể chạy, thắng, bóp kèn.

=> CLASS = blue print -> Object = instance.

2. Các tính chất của OOP (lập trình hướng đối tượng)

- Lập trình hướng đối tượng có 4 tính chất gồm: Đóng gói, Kế thừa, Đa hình, Trừu tượng.

  2.1. Encapsulation (Đóng gói)

- Giấu dữ liệu & chỉ cho phép truy cập thông qua các phương thức (methods) được định nghĩa trong class.
- Tránh việc chỉnh sửa trực tiếp các thuộc tính -> hạn chế sự sai sót và bảo vệ dữ liệu.
- Sử dụng private, protected, public

  2.2. Inheritance (Kế thừa)

- Cho phép một lớp (lớp con) có thể kế thừa lớp khác (lớp cha) để sử dụng lại các phương thức mà lớp cha đã có.
  Giúp tránh việc lặp lại code khi xử lý các logic hoặc cộng việc tương tự

  2.3. Polymorphism (Đa hình)

- Là một đối tượng thuộc các lớp khác nhau có thể hiểu cùng một thông điệp theo cách khác nhau
  VD: Có 2 lớp đại diện cho 2 con vật Chó & Mèo khi nhận được lệnh là "hãy kêu" thì con chó sẽ sủa, con mèo sẽ kêu meo meo.

  2.4. Abstraction (Trừu tượng)

- Là phương pháp định nghĩa bằng lớp trừu tượng (interface) lên những hành động, tính chất của một đối tượng phải có.
  Ví dụ: Khi muốn trừu tượng hóa một lớp con chó thì ta sẽ định nghĩa những thuộc tính và phương thức mà lớp con chó phải có.

4. Nguyên tác SOLID
   S - Single Resonsibility: 1 class = 1 nhiệm vụ.
   O - Open Closed: Dễ mở rộng, hạn chế sửa code cũ.
   L - Liskov Substitution Principle: Class con thay thế class cha mà không động đến logic
   I - Interface Segregation: Nhiều interface nhỏ luôn tốt hơn 1 interface khổng lồ
   D - Dependency Inversion: Phụ thuộc vào abstraction thay vì phụ thuộc vào implementation
