using System.IO;
using System.Text;

namespace St.Common {
    class TextFile {
        public static string Read(string filePath, Encoding encoding) {
            using (var reader = new StreamReader(filePath, encoding)) {
                return reader.ReadToEnd();
            }
        }

        public static void Write(string filePath, string content, Encoding encoding) {
            using (var writer = new StreamWriter(filePath, false, encoding)) {
                writer.Write(content);
            }
        }
    }
}
