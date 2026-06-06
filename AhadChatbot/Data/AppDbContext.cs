using AhadChatbot.Models;
using Microsoft.EntityFrameworkCore;

namespace AhadChatbot.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ChatMessage> ChatMessages { get; set; }

        public DbSet<ChatFile> ChatFiles { get; set; }

        public DbSet<UploadedFile> UploadedFiles { get; set; }

    }
}
