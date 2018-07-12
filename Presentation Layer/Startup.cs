using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business_Layer.Interfaces;
using Business_Layer.Services;
using Data_Access_Layer;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Shared.DTOs;
using FluentValidation;

namespace Presentation_Layer
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
            services.AddSingleton<IUnitOfWork, AirportUnitOfWork>();
            services.AddMvc();
            services.AddAutoMapper();
            

            var mapper = MapperConfiguration().CreateMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Flight, FlightDTO>();
                cfg.CreateMap<Departure, DepartureDTO>();
                cfg.CreateMap<Pilot, PilotDTO>();
                cfg.CreateMap<Plane, PlaneDTO>();
                cfg.CreateMap<PlaneType, PlaneTypeDTO>();
                cfg.CreateMap<Stewardess, StewardessDTO>();
                cfg.CreateMap<Ticket, TicketDTO>();
            });
            return config;
        }
    }
}
