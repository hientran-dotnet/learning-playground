## **Bài 1 – Encapsulation (Dễ)**

**Mô tả:**

Tạo class `BankAccount` với số dư chỉ cho phép rút khi đủ tiền.

- Thuộc tính số dư (Balance): phải được đóng gói, không được thay đổi trực tiếp từ bên ngoài, chỉ được xem số dư
- Phương thức nạp tiền (Deposit): Nhận số tiền đầu vào, chỉ cho phép nạp tiền > 0, Cập nhật số dư
- Phương thức rút tiền (Withdraw): Nhận số tiền đầu vào, chỉ cho phép rút nếu số dư đủ tiền, nếu không đủ thì không rút được.
- Kiểm soát tính hợp lệ: Không cho phép nạp số âm, rút số âm, rút nhiều hơn số dư.

**Yêu cầu:**

- Thuộc tính `Balance` chỉ được thay đổi bởi method.
- Có method: `Deposit()`, `Withdraw()`.

**Gợi ý:**

Dùng field private + property readonly + kiểm tra logic.

**Thời gian:** 10 phút

## **Bài 2 – Inheritance + Polymorphism (Trung bình)**

**Mô tả:**

Tạo class `Shape` và các class con `Circle`, `Rectangle`.

- Tạo lớp trừ tượng Shape. Có: phương thức abstract double GetArea() để tính diện tích
- Tạo lớp Circle kế thừa Shape. Có: thuộc tính là Radious, Constructor nhận vào bán kính. Overide phương thức tính diện tích. Area = pi \* r^2
- Tạo lớp Rectangle kế thừa từ Shape. Có Width và Height. Override GetArea(). Area = width \* height

**Yêu cầu:**

- Mỗi shape phải có method `GetArea()`.
- Dùng `virtual/override`.

**Gợi ý:**

Dùng constructor + override.

**Thời gian:** 15 phút

## **Bài 3 – Interface vs Abstract (Khó hơn)**

**Mô tả:**

Tạo hệ thống Media Player với interface `IPlayable` và abstract class `MediaFile`.

- Tạo interface IPlayable có phương thức Play(). Implement interface IPlayable
- Tạo abstract class MediaFile có Name, Duration, Constructor gán các thuộc tính
- Tạo các lớp con Song và Video kế thừa từ MediaFile

**Yêu cầu:**

- `IPlayable` có `Play()`.
- `MediaFile` có `Name`, `Duration`.
- Tạo `Song` và `Video`.

**Gợi ý:**

Dùng interface cho hành vi; abstract class cho dữ liệu chung.

**Thời gian:** 20 phút
