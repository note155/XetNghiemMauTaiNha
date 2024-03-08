using System.Net.Mail;
using System.Net;
using duanxetnghiem.Client.Pages.Admin.GoiXetNghiem;
using duanxetnghiem.Data;
using duanxetnghiem.Data.Model;
using Microsoft.EntityFrameworkCore;
using Shared.form;
using Shared.ketnoi;
using Shared.Model;

namespace duanxetnghiem.Services
{
    public class KetQuaXetNghiemRepository :IKetQuaXetNghiem
    {
        private readonly ApplicationDbContext _context;

        public KetQuaXetNghiemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<KetQuaXetNghiem> addAsync(KetQuaXetNghiem KetQuaXetNghiem)
        {
            if (KetQuaXetNghiem == null) return null;
            var newstudent = _context.KetQuaXetNghiems.Add(KetQuaXetNghiem).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<KQandCS> addKQandCS(KQandCS kQandCs)
        {
            if (kQandCs == null) return null;
            var newstudent = _context.KQandCSs.Add(kQandCs).Entity;
            await _context.SaveChangesAsync();

            return newstudent;
        }

        public async Task<KetQuaXetNghiem> deleteAsync(int id)
        {
            var ketQuaXetNghiemToDelete = await _context.KetQuaXetNghiems.FindAsync(id);
            if (ketQuaXetNghiemToDelete != null)
            {
                _context.KetQuaXetNghiems.Remove(ketQuaXetNghiemToDelete);
                await _context.SaveChangesAsync();
                return ketQuaXetNghiemToDelete;
            }
            return null;
        }

        public async Task<List<KetQuaXetNghiem>> getallAsync()
        {
            return await _context.KetQuaXetNghiems.ToListAsync();
        }

        public async Task<List<KQandCS>> getallCSbyidAsync(int id)
        {
            var gioHangs = await _context.KQandCSs.Where(g => g.KetQuaXetNghiemId == id).ToListAsync();
            return gioHangs;
        }

        public async Task<KetQuaXetNghiem> getbyid(int Id)
        {
            return await _context.KetQuaXetNghiems.FirstOrDefaultAsync(t => t.DonXetNghiemId == Id);
        }

        public async Task<gmail> guiemail(gmail gm)
        {
            string fromMail = "dolaamphu111@gmail.com";
            string fromPassword = "rxzyfffqavivksfs";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Thông báo Kết Quả Đơn Xét Nghiệm";
            message.To.Add(new MailAddress(gm.email));
            message.Body = "<html><body><p>Kính gửi "+gm.hoten+",</p> <p>Chúng tôi rất vui thông báo cho bạn rằng kết quả đơn xét nghiệm của bạn đã sẵn sàng. Sau quá trình xử lý và kiểm tra cẩn thận, chúng tôi muốn chia sẻ với bạn kết quả của các xét nghiệm mà bạn đã thực hiện.</p><p>Bạn có thể xem chi tiết kết quả bằng cách nhấp vào đường link sau: <a href='https://localhost:7199/XCTDon/"+gm.iddon+ "'>Link Kết Quả</a>.</p><p>Nếu bạn có bất kỳ câu hỏi hoặc cần thêm thông tin, đừng ngần ngại liên hệ với chúng tôi. Đội ngũ chăm sóc khách hàng của chúng tôi luôn sẵn sàng hỗ trợ bạn.</p><p>Chúng tôi khuyến khích bạn thảo luận kết quả này với bác sĩ hoặc nhân viên y tế của bạn để hiểu rõ hơn về ý nghĩa của chúng và bất kỳ hành động nào cần thiết.</p><p>Cảm ơn bạn đã tin tưởng và sử dụng dịch vụ của chúng tôi. Chúc bạn luôn khỏe mạnh và hạnh phúc.</p><p>Trân trọng,</p><p>CÔNG TY TNHH GIẢI PHÁP PHẦN MỀM ÂU LẠC<br>[Link Kết Quả]:<a href='https://localhost:7199/XCTDon/"+gm.iddon+"'>Xem kết quả</a></p></body></html>";
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

        public async Task<KetQuaXetNghiem> updateAsync(KetQuaXetNghiem ketQuaXetNghiem)
        {
            if (ketQuaXetNghiem == null) return null;

            var updateKetQuaXetNghiem = _context.KetQuaXetNghiems.Update(ketQuaXetNghiem).Entity;

            await _context.SaveChangesAsync();

            return updateKetQuaXetNghiem;
        }
    }
}
