using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartLoadManagement.Interfaces;
using SmartLoadManagement.Repositories;

namespace SmartLoadManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<IAchv_Customer_Repository, Achv_Customer_Repository>();
            services.AddTransient<IAchv_LineLoss_Repository, Achv_LineLoss_Repository>();
            services.AddTransient<IAchv_LineLoss_PowerGrid_Repository, Achv_LineLoss_PowerGrid_Repository>();
            services.AddTransient <IAchv_LoadCtrl_Repository, Achv_LoadCtrl_Repository> ();
            services.AddTransient <IAchv_LoadCtrl_Meter_Repository, Achv_LoadCtrl_Meter_Repository> ();
            services.AddTransient <IAchv_Meter_Repository, Achv_Meter_Repository> ();
            services.AddTransient <IAchv_Poc_Repository, Achv_Poc_Repository> ();
            services.AddTransient <IAchv_PowerGrid_Repository, Achv_PowerGrid_Repository> ();
            services.AddTransient <IAchv_Sim_Repository, Achv_Sim_Repository> ();
            services.AddTransient <IAchv_Tml_Repository, Achv_Tml_Repository> ();
            services.AddTransient <ILog_Login_Repository, Log_Login_Repository> ();
            services.AddTransient <ILog_Msg_Repository, Log_Msg_Repository> ();
            services.AddTransient <ILog_Operating_Repository, Log_Operating_Repository> ();
            services.AddTransient <ILog_Password_Repository, Log_Password_Repository> ();
            services.AddTransient <IPrm_Collect_Repository, Prm_Collect_Repository> ();
            services.AddTransient <IPrm_Collect_Plan_Repository, Prm_Collect_Plan_Repository> ();
            services.AddTransient <IPrm_Collect_Plan_Obis_Repository, Prm_Collect_Plan_Obis_Repository> ();
            services.AddTransient <IPrm_Device_Deleted_Repository, Prm_Device_Deleted_Repository> ();
            services.AddTransient <IPrm_FeeInd_Repository, Prm_FeeInd_Repository> ();
            services.AddTransient <IPrm_FeeTbl_Repository, Prm_FeeTbl_Repository> ();
            services.AddTransient <IPrm_MeterType_Repository, Prm_MeterType_Repository> ();
            services.AddTransient <IPrm_SG_Repository, Prm_SG_Repository> ();
            services.AddTransient <IPrm_SgKey_Repository, Prm_SgKey_Repository> ();
            services.AddTransient <IPrm_Supplier_Repository, Prm_Supplier_Repository> ();
            services.AddTransient <IPrm_TmlType_Repository, Prm_TmlType_Repository> ();
            services.AddTransient <IPrm_TrFind_Repository, Prm_TrFind_Repository> ();
            services.AddTransient <IPrm_TrfTbl_Repository, Prm_TrfTbl_Repository> ();
            services.AddTransient <ISys_Notice_Repository, Sys_Notice_Repository> ();
            services.AddTransient <ISys_Notice_User_Repository, Sys_Notice_User_Repository> ();
            services.AddTransient <ISys_Page_Repository, Sys_Page_Repository> ();
            services.AddTransient <ISys_Role_Repository, Sys_Role_Repository> ();
            services.AddTransient <ISys_Role_Page_Repository, Sys_Role_Page_Repository> ();
            services.AddTransient <ISys_User_Repository, Sys_User_Repository> ();
            services.AddTransient <ISys_User_Subscribe_Repository, Sys_User_Subscribe_Repository> ();
            services.AddTransient <ISys_UserGroup_Repository, Sys_UserGroup_Repository> ();
            services.AddTransient <ISys_UserGroup_Obj_Repository, Sys_UserGroup_Obj_Repository> ();
            services.AddTransient <ISys_UserGroup_User_Repository, Sys_UserGroup_User_Repository> ();
            services.AddTransient <IVnd_Mch_Credit_Repository, Vnd_Mch_Credit_Repository> ();
            services.AddTransient <IVnd_Mch_Repository, Vnd_Mch_Repository> ();
            services.AddTransient <IVnd_Mch_User_Repository, Vnd_Mch_User_Repository> ();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
