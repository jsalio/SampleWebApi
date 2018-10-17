using System;
using System.IO;

namespace ClassLibrary1
{
    public sealed class NotificationLog
    {
        public void WriteDocumentNotification(string fileCcontent)
        {
            var id = Guid.NewGuid().ToString();
            string file = $@"C:\uncomingMesage\DocumentChange\Document{id}.txt";
            TryCreateDirectory($@"C:\uncomingMesage\DocumentChange");
            File.WriteAllText(file, fileCcontent);
        }

        public void WriteBatchNotification(string fileCcontent)
        {
            var id = Guid.NewGuid().ToString();
            string file = $@"C:\uncomingMesage\BatchChange\Batch{id}.txt";
            TryCreateDirectory($@"C:\uncomingMesage\BatchChange");
            System.IO.File.WriteAllText(file, fileCcontent);
        }

        public void WriteBatchIndexNotification(string fileCcontent)
        {
            var id = Guid.NewGuid().ToString();
            string file = $@"C:\uncomingMesage\BatchIndex\batch{id}.txt";
            TryCreateDirectory($@"C:\uncomingMesage\BatchIndex");
            System.IO.File.WriteAllText(file, fileCcontent);
        }

        public void WriteDocumentIndexNotification(string fileCcontent)
        {
            var id = Guid.NewGuid().ToString();
            string file = $@"C:\uncomingMesage\DocumentIndex\document{id}.txt";
            TryCreateDirectory($@"C:\uncomingMesage\DocumentIndex");
            System.IO.File.WriteAllText(file, fileCcontent);
        }

        private void TryCreateDirectory(string directory)
        {
            if (!System.IO.Directory.Exists(directory))
            {
                try
                {
                    Directory.CreateDirectory(directory);
                }
                catch (Exception ex)
                {
                    // handle them here
                }
            }
        }
    }
}
