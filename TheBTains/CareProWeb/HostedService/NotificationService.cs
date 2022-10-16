using CareProWeb.Common;
using CareProWeb.Core.Interfaces;

namespace CareProWeb.HostedService
{
    public class NotificationService : IHostedService, IAsyncDisposable
    {
        private readonly IUnitOfWork _unitOfWork;

        public NotificationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            while (true)
            {
                var prescriptions = await _unitOfWork.PDailyMed.GetAll();
                foreach (var item in prescriptions)
                {
                    if (!item.MedTaken)
                    {
                        var publisher = new PushNotification(item.MedName);
                        item.MedTaken = true;
                        await _unitOfWork.PDailyMed.Update(item);
                    }
                }
            }
            await Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
    }
}
