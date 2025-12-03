PHẦN 2 - ASYNC /AWAIT & Task

I. Lý thuyết

1. Cơ chế async/await

- async dùng để đánh dấu method là bất đồng bộ
- await dùng để dừng chờ method -> không chặn thread
- Khi task haonf thành -> tiếp tục thực thi

* Lưu ý:

- async void: chỉ dùng cho event handler
- async Task: dùng cho method không trả kết quả
- async Task<T>: trả kế quả với kiểu T

2. Task, Task<T>

- Task: biễu diễn 1 công việc chạy bất đồng bộ
- Task<T>: trả về giá trị với kiểu T

3. ConfigureAwait(False)

- Bỏ qua việc quay lại SynchronizationContext
- Dùng trong library để tránh deadlock

4. CancellationToken

- Để hủy task

```csharp
var cts = new CancellationTokenSource();
cts.Cancel();

```

5. Exception trong async

- Exception sẽ được gói trong Task
- Dùng await để bung lỗi
- Nếu không await -> lỗi bị nuốt

```csharp
try { await DoWorkAsync(); }
catch(Exception ex) { ... }

```
