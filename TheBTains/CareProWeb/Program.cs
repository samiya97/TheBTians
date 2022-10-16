using CareProWeb.Core.Interfaces;
using CareProWeb.Hubs;
using CareProWeb.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddSignalR();

builder.Services.AddTransient<ILoginRepository, LoginRepository>();
builder.Services.AddTransient<IDoctorRepository, DoctorRepository>();
builder.Services.AddTransient<IPatientRepository, PatientRepository>();
builder.Services.AddTransient<IAppointCheckUpRepository, AppointCheckUpRepository>();
builder.Services.AddTransient<ICheckupScheduleRepository, CheckupScheduleRepository>();
builder.Services.AddTransient<IComplainSymptomsRepository, ComplainSymptomsRepository>();
builder.Services.AddTransient<IDoctorDetailsRepository, DoctorDetailsRepository>();
builder.Services.AddTransient<IDoctorNotificationRepository, DoctorNotificationRepository>();
builder.Services.AddTransient<IDoctorPatientsRepository, DoctorPatientsRepository>();
builder.Services.AddTransient<IDoctorReviewsRepository, DoctorReviewsRepository>();
builder.Services.AddTransient<IDoctorsPrescriptionRepository, DoctorsPrescriptionRepository>();
builder.Services.AddTransient<IHospitalsRepository, HospitalsRepository>();
builder.Services.AddTransient<ILabTestCategoryRepository, LabTestCategoryRepository>();
builder.Services.AddTransient<INotificationTypeRepository, NotificationTypeRepository>();
builder.Services.AddTransient<IPatientDetailsRepository, PatientDetailsRepository>();
builder.Services.AddTransient<IPatientNotificationRepository, PatientNotificationRepository>();
builder.Services.AddTransient<IPDailyMedRepository, PDailyMedRepository>();
builder.Services.AddTransient<IPLabTestAppointmentRepository, PLabTestAppointmentRepository>();
builder.Services.AddTransient<ISignUpRepository, SignUpRepository>();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
});
var app = builder.Build();

app.UseSession();
// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
    app.UseExceptionHandler("/Home/Error");
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
//}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "api/{controller=Home}/{action=Index}/{id?}");
//app.MapRazorPages();
app.MapHub<NotificationHub>("/notification");

app.Run();

Console.WriteLine("asdaasd");
