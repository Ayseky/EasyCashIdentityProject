Identity paketleri kuruldu.
Microsoft.AspNetCore.Identity
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Context nesnesi artık Dbcontezt sınıfını değil IdentityDbContext sınıfını referans alacak.
AppUser ve AppRole entitylerinin dbcontext sınıfı içerisinde dbset ile belirtilmesine gerek yok çünkü Identityden referans alıyor.
