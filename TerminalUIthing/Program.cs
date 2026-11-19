using Terminal.Gui;

// ۱. راه‌اندازی اولیه موتور ترمینال
Application.Init();

// ۲. ساخت پنجره اصلی با قابلیت تغییر اندازه خودکار (Fill)
var win = new Window ("داشبرد نود مولک - Molok Node") {
    X = 0,
    Y = 1, // یک خط فاصله برای منوی بالایی (اختیاری)
    Width = Dim.Fill (),
    Height = Dim.Fill ()
};

// ۳. اضافه کردن یک متن (Label)
var label = new Label (3, 2, "وضعیت اتصال به سرور مرکزی (molok.org):");
win.Add (label);

// ۴. اضافه کردن یک فیلد متنی (TextField) برای ورود دستور یا کلید دسترسی
var textEntry = new TextField ("") {
    X = 3,
    Y = 4,
    Width = 40
};
win.Add (textEntry);

// ۵. اضافه کردن یک دکمه (Button)
var button = new Button (3, 6, "ارسال پکت داده");
button.Clicked += () => {
    // باز کردن یک پیام هشدار (MessageBox)
    MessageBox.Query (30, 10, "ارسال شد", $"داده شما دریافت شد:\n{textEntry.Text.ToString()}", "باشه");
};
win.Add (button);

// ۶. افزودن پنجره به صفحه اصلی (Top)
Application.Top.Add (win);

// ۷. اجرای حلقه اصلی برنامه (برنامه اینجا باز می‌ماند تا کاربر خارج شود)
Application.Run ();

// ۸. پاکسازی و بستن ترمینال بعد از خروج کاربر
Application.Shutdown ();