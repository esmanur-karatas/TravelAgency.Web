using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using TravelAgency.Web.CQRS.Handlers.DestinationHandlers;
using TravelAgency.Web.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<Context>();


        builder.Services.AddScoped<ICommentService, CommentManager>();
        builder.Services.AddScoped<ICommentDal, EfCommentDal>();

        builder.Services.AddScoped<IDestinationService, DestinationManager>();
        builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();

        builder.Services.AddScoped<IAppUserService, AppUserManager>();
        builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();

        builder.Services.AddScoped<IReservationService, ReservationManager>();
        builder.Services.AddScoped<IReservationDal, EfReservationDal>();

        builder.Services.AddScoped<IGuideService, GuideManager>();
        builder.Services.AddScoped<IGuideDal, EfGuideDal>();

        builder.Services.AddScoped<IExcelService, ExcelManager>();
        builder.Services.AddScoped<IPdfService, PdfManager>();

        builder.Services.AddScoped<IContactUsService, ContactUsManager>();
        builder.Services.AddScoped<IContactUsDal, EfContactUsDal>();

        builder.Services.AddScoped<IContactService, ContactManager>();
        builder.Services.AddScoped<IContactDal, EfContactDal>();

        builder.Services.AddScoped<IHotelsService, HotelsManager>();
        builder.Services.AddScoped<IHotelsDal, EfHotelsDal>();

        builder.Services.AddScoped<IAnnouncementService, AnnouncementManager>();
        builder.Services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

        builder.Services.AddScoped<IPackageService, PackageManager>();
        builder.Services.AddScoped<IPackageDal, EfPackageDal>();

        builder.Services.AddScoped<IRestuarantService, RestuarantManager>();
        builder.Services.AddScoped<IRestuarantDal, EfRestuarantDal>();

        builder.Services.AddScoped<GetAllDestinationQueryHandler>();
        builder.Services.AddScoped<GetDestinationByIdQueryHandler>();
        builder.Services.AddScoped<CreateDestinationCommandHandler>();
        builder.Services.AddScoped<RemoveDestinationCommandHandler>();
        builder.Services.AddScoped<UpdateDestinationCommandHandler>();

        builder.Services.AddAutoMapper(typeof(Program));
        builder.Services.AddMediatR(typeof(Program));

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/Login/SignIn";
        });
        //LOGLAMA ��LEMLER�
        builder.Services.AddLogging(x =>
        {
            x.ClearProviders();
            x.SetMinimumLevel(LogLevel.Debug);
            x.AddDebug();
        });
        var path = Directory.GetCurrentDirectory();
        builder.Logging.AddFile($"{path}/Logs/Log1.txt");

        object value = builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomeIdentityValidator>().AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();
        builder.Services.AddMvc(config =>
        {
            var policy = new AuthorizationPolicyBuilder()
            .RequireAuthenticatedUser()
            .Build();
            config.Filters.Add(new AuthorizeFilter(policy));
        });

        builder.Services.AddHttpClient();

        var app = builder.Build();
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();

        }

        app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseAuthentication();
        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
              name: "areas",
              pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );
        });

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
              name: "areas",
              pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );
        });
        app.Run();
    }
}