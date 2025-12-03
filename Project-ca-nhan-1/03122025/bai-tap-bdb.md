## **Bài 1 – Await cơ bản (Dễ)**

**Mô tả:**

Tạo method `DelayPrintAsync()` in ra một dòng sau 2 giây.

**Yêu cầu:**

- Dùng `Task.Delay`.
- Không block thread chính.

**Gợi ý:**

`await Task.Delay(2000);`

**Thời gian:** 5 phút

### ✔ Code mẫu

```csharp
static async Task DelayPrintAsync()
{
    await Task.Delay(2000);
    Console.WriteLine("Done");
}

```

---

## **Bài 2 – Task<T> (Trung bình)**

**Mô tả:**

Tạo method tính tổng của mảng số nguyên bất đồng bộ.

**Yêu cầu:**

- `Task<int> SumAsync(int[] nums)`
- Dùng `Task.Run`.

**Gợi ý:**

Dùng `nums.Sum()`.

**Thời gian:** 10 phút

### ✔ Code mẫu

```csharp
static Task<int> SumAsync(int[] arr)
{
    return Task.Run(() => arr.Sum());
}

```

---

## **Bài 3 – CancellationToken (Trung bình–Khó)**

**Mô tả:**

Tạo method download giả lập 5 giây, có thể hủy.

**Yêu cầu:**

- Nếu token bị hủy → ném `OperationCanceledException`.

**Thời gian:** 15 phút

### ✔ Code mẫu

```csharp
static async Task DownloadAsync(CancellationToken token)
{
    for(int i = 0; i < 5; i++)
    {
        token.ThrowIfCancellationRequested();
        Console.WriteLine($"Downloading... {i+1}/5");
        await Task.Delay(1000, token);
    }
}

```

---

## **Bài 4 – Exception Handling (Khó)**

**Mô tả:**

Tạo method đọc file async → nếu file không tồn tại thì bắt lỗi.

**Yêu cầu:**

- Dùng `File.ReadAllTextAsync`.
- Bắt `FileNotFoundException`.

**Thời gian:** 20 phút

### ✔ Code mẫu

```csharp
static async Task ReadFileAsync(string path)
{
    try
    {
        string content = await File.ReadAllTextAsync(path);
        Console.WriteLine(content);
    }
    catch(FileNotFoundException ex)
    {
        Console.WriteLine("File not found!");
    }
}

```

---

## **Bài 5 – Chạy nhiều Task song song (Khó)**

**Mô tả:**

Chạy 3 task giả lập API call → tổng thời gian < 3 giây.

**Yêu cầu:**

- Dùng `Task.WhenAll`.

**Thời gian:** 20 phút

### ✔ Code mẫu
