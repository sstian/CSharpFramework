using System.AddIn.Pipeline;
using Contract;

namespace HostSideAdapter {
    // Contract to View
    [HostAdapter]
    public class ImageProcessorHostAdapter : HostView.ImageProcessorHostView {
        private Contract.IImageProcessorContract contract;
        private ContractHandle contractHandle;

        public ImageProcessorHostAdapter(IImageProcessorContract contract) {
            this.contract = contract;
            this.contractHandle = new ContractHandle(contract);
        }

        public override byte[] ProcessImageBytes(byte[] pixels) {
            return contract.ProcessImageBytes(pixels);
        }
    }
}
