using System.Threading.Tasks;

namespace Publisher
{
    interface IPublisher
	{
		Task Publish<T>(T message);
    }
}
