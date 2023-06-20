using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRChat.Inicializacao))]

namespace SignalRChat
{
    public class Inicializacao
    {
        public void Configuration(IAppBuilder app)
        {
            // Para obter mais informações sobre como configurar seu aplicativo, visite https://go.microsoft.com/fwlink/?LinkID=316888
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
