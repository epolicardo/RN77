namespace RN77.LibComun.AzureManagement
{
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Blob;
    public class AzureStorageManagement
    {
        private readonly CloudStorageAccount cloudAccount;
        private CloudBlobClient client;
        private CloudBlobContainer container;

        public AzureStorageManagement(string connectionString, string containerName)
        {
            client = cloudAccount.CreateCloudBlobClient();
            container = client.GetContainerReference(containerName);
        }


    }
}
