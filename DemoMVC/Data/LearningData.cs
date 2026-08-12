using DemoMVC.Models;
namespace DemoMVC.Data;

public static class LearningData
{
    public static IReadOnlyList<Lesson> Lessons { get; } =
    [
        // =====================================================
        // 01. OVERVIEW
        // =====================================================
        new()
        {
            Id = 1,
            ChapterId = 1,
            ChapterTitle = "Overview",
            Title = "Hình thức học tập và thi kết thúc học phần",
            Level = "Cơ bản",
            Order = 1
        },
        new()
        {
            Id = 2,
            ChapterId = 1,
            ChapterTitle = "Overview",
            Title = "Công nghệ sử dụng",
            Level = "Cơ bản",
            Order = 2
        },
        new()
        {
            Id = 3,
            ChapterId = 1,
            ChapterTitle = "Overview",
            Title = "Cài đặt và thiết lập môi trường lập trình",
            Level = "Cơ bản",
            Order = 3
        },
        new()
        {
            Id = 4,
            ChapterId = 1,
            ChapterTitle = "Overview",
            Title = "Thiết lập quy trình CI/CD",
            Level = "Cơ bản",
            Order = 4
        },
        // =====================================================
        // 02. .NET MVC
        // =====================================================
        new()
        {
            Id = 5,
            ChapterId = 2,
            ChapterTitle = ".NET MVC",
            Title = "MVC Pattern",
            Level = "Cơ bản",
            Order = 1
        },
        new()
        {
            Id = 6,
            ChapterId = 2,
            ChapterTitle = ".NET MVC",
            Title = "Routing",
            Level = "Cơ bản",
            Order = 2
        },
        new()
        {
            Id = 7,
            ChapterId = 2,
            ChapterTitle = ".NET MVC",
            Title = "Controller, Model, View",
            Level = "Cơ bản",
            Order = 3
        },
        new()
        {
            Id = 8,
            ChapterId = 2,
            ChapterTitle = ".NET MVC",
            Title = "Quản lý trạng thái",
            Level = "Cơ bản",
            Order = 4
        },
        new()
        {
            Id = 9,
            ChapterId = 2,
            ChapterTitle = ".NET MVC",
            Title = "Layout, Partial View, View Component",
            Level = "Cơ bản",
            Order = 5
        },
        // =====================================================
        // 03. DATABASE
        // =====================================================
        new()
        {
            Id = 10,
            ChapterId = 3,
            ChapterTitle = "Database",
            Title = "Thiết lập kết nối CSDL",
            Level = "Trung bình",
            Order = 1
        },
        new()
        {
            Id = 11,
            ChapterId = 3,
            ChapterTitle = "Database",
            Title = "Migration",
            Level = "Trung bình",
            Order = 2
        },
        new()
        {
            Id = 12,
            ChapterId = 3,
            ChapterTitle = "Database",
            Title = "CRUD",
            Level = "Trung bình",
            Order = 3
        },
        new()
        {
            Id = 13,
            ChapterId = 3,
            ChapterTitle = "Database",
            Title = "LINQ",
            Level = "Trung bình",
            Order = 4
        },
        new()
        {
            Id = 14,
            ChapterId = 3,
            ChapterTitle = "Database",
            Title = "AJAX CRUD",
            Level = "Trung bình",
            Order = 5
        },
        new()
        {
            Id = 15,
            ChapterId = 3,
            ChapterTitle = "Database",
            Title = "Excel",
            Level = "Trung bình",
            Order = 6
        },
        // =====================================================
        // 04. AUTHENTICATION & AUTHORIZATION
        // =====================================================
        new()
        {
            Id = 16,
            ChapterId = 4,
            ChapterTitle = "Authentication & Authorization",
            Title = "Login / Register",
            Level = "Nâng cao",
            Order = 1
        },
        new()
        {
            Id = 17,
            ChapterId = 4,
            ChapterTitle = "Authentication & Authorization",
            Title = "ASP.NET Core Identity",
            Level = "Nâng cao",
            Order = 2
        },
        new()
        {
            Id = 18,
            ChapterId = 4,
            ChapterTitle = "Authentication & Authorization",
            Title = "Authentication",
            Level = "Nâng cao",
            Order = 3
        },
        new()
        {
            Id = 19,
            ChapterId = 4,
            ChapterTitle = "Authentication & Authorization",
            Title = "Authorization",
            Level = "Nâng cao",
            Order = 4
        }
    ];
}