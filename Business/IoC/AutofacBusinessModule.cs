using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IoC
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<EfTypesDal>().As<ITypesDal>(); 
            builder.RegisterType<EfServiceDal>().As<IServiceDal>();
            builder.RegisterType<EfRoomDal>().As<IRoomDal>();
            builder.RegisterType<EfReservationDal>().As<IReservationDal>();
            builder.RegisterType<EfRes_ServicesDal>().As<IRes_ServiceDal>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();
            builder.RegisterType<EfAdminDal>().As<IAdminDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<TypesManager>().As<ITypesService>();
            builder.RegisterType<ServiceManager>().As<IService_Service>();
            builder.RegisterType<RoomManager>().As<IRoomService>();
            builder.RegisterType<ReservationManager>().As<IReservationService>();
            builder.RegisterType<ResServiceManager>().As<IResServices_Service>();
            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<AdminManager>().As<IAdminService>();
        }
    }
}
