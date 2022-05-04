using System.AddIn.Contract;
using System.AddIn.Pipeline;

namespace Contract {
    [AddInContract]
    public interface IImageProcessorContract : IContract {
        byte[] ProcessImageBytes(byte[] pixels);
    }
}
