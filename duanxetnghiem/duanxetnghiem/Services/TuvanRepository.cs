using System.Net.Mail;
using System.Net;
using duanxetnghiem.Client.Pages.User.DichVu_user;
using duanxetnghiem.Data;
using Microsoft.EntityFrameworkCore;
using Shared.form;
using Shared.ketnoi;
using Shared.Model;
using GoogleMapsComponents.Maps;

namespace duanxetnghiem.Services
{
    public class TuvanRepository : ITuvan
    {
        private readonly ApplicationDbContext _context;

        public TuvanRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Tuvan> addAsync(Tuvan tuvan)
        {
            if (tuvan == null) return null;
            var newstudent = _context.Tuvans.Add(tuvan).Entity;
            await _context.SaveChangesAsync();
            return newstudent;
        }

        public async Task<List<Tuvan>> getallAsync()
        {
            return await _context.Tuvans.ToListAsync();
        }

        public async Task<Tuvan> getbyidAsync(int id)
        {
            return await _context.Tuvans.FirstOrDefaultAsync(t => t.id == id);
        }

        public async Task<gmailTV> guiemail(gmailTV gm)
        {
            string fromMail = "dolaamphu111@gmail.com";
            string fromPassword = "rxzyfffqavivksfs";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Trả Lời Tư Vấn - Âu Lạc";
            message.To.Add(new MailAddress(gm.email));
            message.Body = "<html><body><p>Chào "+gm.hotenKH+",</p><p>Chúng tôi hy vọng bạn đang khỏe mạnh và an lành. Xin gửi đến bạn kết quả tư vấn dựa trên thông tin bạn đã cung cấp:</p><p>Sau khi chuyên gia của chúng tôi đã phân tích, kết quả tư vấn cho thấy:</p><p>"+gm.noidung+"</p><p>Nếu bạn có bất kỳ câu hỏi hoặc cần hỗ trợ thêm, đừng ngần ngại liên hệ với chúng tôi qua email này hoặc số điện thoại dưới đây. Chúng tôi luôn sẵn lòng hỗ trợ bạn.</p><p>Trân trọng,</p><p>"+gm.hotenBS+"<br>Bác sĩ<br>CÔNG TY TNHH GIẢI PHÁP PHẦN MỀM ÂU LẠC<br></p></body></html>";
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
            return gm;
        }

        public async Task<Tuvan> updateAsync(Tuvan tuvan)
        {
            if (tuvan == null) return null;

            var updateuser = _context.Tuvans.Update(tuvan).Entity;

            await _context.SaveChangesAsync();

            return updateuser;
        }
    }
}
