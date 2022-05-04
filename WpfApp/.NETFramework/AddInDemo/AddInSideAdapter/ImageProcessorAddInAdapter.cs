using System.AddIn.Pipeline;
using AddInView;

namespace AddInSideAdapter {
    public class ImageProcessorAddInAdapter : ContractBase, Contract.IImageProcessorContract {
        private AddInView.ImageProcessorAddInView view;

        public ImageProcessorAddInAdapter(ImageProcessorAddInView view) {
            this.view = view;
        }

        public byte[] ProcessImageBytes(byte[] pixels) {
            return this.view.ProcessImageBytes(pixels);
        }
    }
}
