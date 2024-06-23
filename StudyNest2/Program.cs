using Business.Abstract;
using Business.Concrete.Managers;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUserService, UserManager>();
builder.Services.AddSingleton<IUserDAL,EfUserDAL>();

builder.Services.AddSingleton<IStudentService, StudentManager>();
builder.Services.AddSingleton<IStudentDAL, EfStudentDAL>();

builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICategoryDAL, EfCategoryDAL>();

builder.Services.AddSingleton<ICourseService, CourseManager>();
builder.Services.AddSingleton<ICourseDAL, EfCourseDAL>();

builder.Services.AddSingleton<ITeacherService, TeacherManager>();
builder.Services.AddSingleton<ITeacherDAL, EfTeacherDAL>();

builder.Services.AddSingleton<IChapterService, ChapterManager>();
builder.Services.AddSingleton<IChapterDAL, EfChapterDAL>();

builder.Services.AddSingleton<IEnrolmentService, EnrolmentManager>();
builder.Services.AddSingleton<IEnrolmentDAL, EfEnrolmentDAL>();

builder.Services.AddSingleton<IChapterCheckService, ChapterCheckManager>();
builder.Services.AddSingleton<IChapterCheckDAL, EfChapterCheckDAL>();
builder.Services.AddDbContext<StudyNestContext>();

builder.Services.AddScoped<IUserWithCoursesService, UserWithCoursesManager>();
builder.Services.AddScoped<IUserWithCoursesDAL, EfUserWithCoursesDAL>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("http://localhost:3000")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors();
}

app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
