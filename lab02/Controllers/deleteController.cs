﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab02.Models;

namespace lab02.Controllers
{
    public class deleteController : Controller
    {
        // GET: delete
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult delete(int id)
        {
            var book = new List<books>();
            book.Add(new books(1, "Tuổi Trẻ Đáng Gía Bao Nhiêu?", "Rosie Nguyễn", "https://cdn0.fahasa.com/media/flashmagazine/images/page_images/tuoi_tre_dang_gia_bao_nhieu_tai_ban_2018/2019_11_05_09_19_54_1.jpg"));
            book.Add(new books(2, "Đừng chạy theo số đông", "Kiên Trần", "https://www.netabooks.vn/Data/Sites/1/Product/35663/dung-chay-theo-so-dong.jpg"));
            book.Add(new books(3, "LẬP TRÌNH VÀ CUỘC SỐNG", "Jeff  Atwood (dịch giả: Hồ Sỹ Hùng)", "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxITEhUSExMWFhUXGBUXGBUXFhoVFxUXFRcWFxcVGBcYICggGholGxcXIjEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OGxAQGy0lICUtLS0tLS0rLSstLSstLS0tLS0tLSstLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIAREAuQMBIgACEQEDEQH/xAAcAAABBQEBAQAAAAAAAAAAAAAEAAEDBQYCBwj/xABMEAACAQMCAgUHBwYNAwUBAAABAgMABBESIQUxBhMiQVEUMmFxgZGhFSNCUpOx0QczQ1NUwRYkNGJyc3SSorKz0vBjgrQ1ZKPC4SX/xAAZAQADAQEBAAAAAAAAAAAAAAAAAQIDBAX/xAAyEQACAgEDAwIDBgYDAAAAAAAAAQIRAxIhMQRBURNhIlKhBRRiscHwIzNxgZHRQnLx/9oADAMBAAIRAxEAPwDyUcTuzv18/wBq/wCNJeKXZ/Tz/av+NV+o0tR8aYiwbid2P08/j+df8aQ4nd/r5/tX/Gq/WfGlqPjRsBY/KV3+vn+1f8aXyld/r5/tX/Gq4OfE0Xb8OuHdI0hlZ5F1xoqMWkXtdpABlh2W3H1T4UbATtxG7GPn5t+Xzr/jT+XXn6+f7V/xrmbgd4kqQvbTrK+6RNE4d+fmqRk8jy8Ke64JexukcltcJJIcRo8bq0h2GEUjLcxy8aA3EOIXm/z8+3/Vf8aY8SvBv18+P61/xrjifCbq30+UQTQ686etjaPVpxnGoDOMj3iuOG8PuJ2KQRSyuAWKxI0jBRgaiFBwMkb+mjYCZuI3g5zz/av+NO/ELwDJnnA/rX/GufkW867yfyefrsZ6nq36zGM6tGM4xvmurng15HIsUlvOkjAssbRuHZVBLMqkZIAB9xo2Dcdb69P6af7V/wAa5XiV2f0832r/AI1DLY3CqXaKVV0o+ooyrol2jfJGNLYOD342qZ+A3oi8oNrcCEqG60xOI9J5NrxjSdt+W9GwbjNxO7G5uJvtX/Go/lm5/aJvtX/GprTgN7LH1sVrcSRb/OJE7p2efaAxt31xw7gV3cKXgtp5lBwWiieQA4BwSoO+CDj00AcfLNz+0Tfav+NL5Zuf2ib7V/xoIjGxpqADvlm5/aJvtX/Gl8s3P7RN9q/40FSoAN+Wbn9om+1f8aXyzc/tE32r/jQVKgA4cZuf2ib7V/xo/wCU5/1832r/AO6qIVaaaEJkLRxdx99Lq4frVELZd+2NuXppJbqebgfGtNXsTp9zopH40tEfj8aY2yY/OfCuY4FPNwPZRq9gr3CLYQh1LrrUEFkD6Cw711AHTnxwa0kHSuNLu3uUgUJbwtAkJl1ZRkmU6pGQgnMzHdcbAY51kJYQDhTqHjyohbSM85QPZmjVfYK9zWv0nVr2G+jtgphUjQChVsB9yY4UUY6zfKnuyeVA23SRhdW91L1btAyuqrHFbg4IbB6lAN/Eg03CePRW6IupiV0+amoaklkl1Y1oO0JFXOT+a3GMVwnF7NyuqA/oF7Sq2BGIE1GTzsBY5BoC4bVk77A1r5UPS/IPxHiDXJQSsjMuQojhii87GRiFF1HYc8+iieB8XW0E6qkbGZUQiVVkVdEivvG4IY9nG/I791DXV7Ak79WWCtCsZliQRsHwheREBA3IKkAgEM2Djm8PFLX9JHJKcjLSIrOxBTEpYsTgKCoh3UjGWp+ovlQtD8kvSPiqXbxu6ohSFIgI8IuFLEMqKAFB1chttXcnGVN+b9MLIbgzhQxIBMmvRnAypzpO24Jrmfj9sSMw6+1ECWjQfNrFbRyBUBKozdS+NPLUMEY2ju762Q2kkQXUkiyOqIFZUUQ4jLbdY2pZDqO+/hij1V8qDQ/LLXpP0u8shELJGiCTUCp36pA4gt84GUi6yTH9PkO9XHSmButcW4FxLbi3ebr2K6eqSIsIdOxKoPpbHx5VUW3G7Yxokluo0sxwiB1ZWKakAkfKFguOsG642G5rk8XticdQqDLaWEMblezCq5RiA/mzZBOMyhtyowvUXyoel+S34T0kghFq7W3WSWmVhl69kQfOyTqHjCEMQ0jfSGQBQ/AOkEFvCkTwdd1dx5TG3XmLTIFjUAgI2ofNg8xzqt4nxGB4nSKMRgtCVTG40CbU7OPOPbCjJzg8tqoqWtfKFe5Z3kqSSPIxGp3Zzjll2LHHoyah0R+PxoKlT9T2QafcN0R+PxpaI/Ee+gqVHqewtPuHaI/H40tEfj8aBpUep7INPuHaI/8AhovaqcVb0nK+wafcjkRs6cx+Oru27s13LqAzqiPPYCqinqbKoIN2TjIBwcipH4ixUrpTB/m0FSothSClvmG2B7vVt8K7HEW6sxYXSc76d9znnQVKi2FIPt+KMgAVE28VyffRHC+NCObrZIUkXD5TSmCWRlUjWrL2SQ26nzaqaMhuYwO1Fk+IOKa37jSRob7pTaOrKLFQW6olhIRpZFIbTtkAliMZ3wCdzt1xfpPZMkkUFloBA0yF8MCFkGoqAd9Umcajsq8qza3SA/mwR4ZNdz3cTfoseo+mnfuF0aG56WW79hLCKNTKkhVSuhgsquAwKZJ0hk56cSN2eWCvKwWDvZ27RhJEWMsnYLXPWhhhR5sYEeMYJ1MR22BzkvELY8rbTtjOs++uLK+hRHV4TIzZ0uWxp2xy+NJJdxWzSv0lt9ZRuGxM2ZMOxRiutlIwTFhlTGFBGAoUctWc5xPhja3kCoiMzsqBw2lSSQgxjOBtyHKokvo9IUx5OOed8/hXdtfQAMGg1EnY6yMDwoqIWyOLhEjDOVHI4Lb707cIkHMr/eBpG7hDahGRtjSTkZ8c0XaRCQZW3J8cNjOMU0kK2Vw4e+nXtj17+6u34XIO9f7wouSLS28LDV5oLd/fXL2RGSYTvuO15tFBYJHw5yAdsHxIFcCybJG2xxz2olULLtF35znfA513cKAwPU4XljVzJ9NKkOwccOc5wV2/nCoJ7cpz+G9GyW5bZYip8c59lCXEoIC6cEc/TikwsgFW9VAq2zQgYbLaRd1o/wDfzn1VXzPAHOqJhgY6vPJvSaGTr8DHWY7sZxXAtpGJOliRz2JPtqm/CEkTSTwFdoyDg76sjPdQNTm0kGcowwMnII28fVTC1c/Qb3GpdsZPwrhU1wxSFNbKusjUqgKCq5JYgc2Ue2iJOATJPFBNohMmCHd10BCzLrLKSMAq3Lfs4xmrboZbOpuiykZthzH/ALq0/GrHiVoZLzha6SVZYVJxt2r+4BzWnpfw9fvX0MvV/i+n7X9TUt0BiMfkum3Xfqw+uM3IbunL6sMdeQYQfNOBvhq84Tohdtlo0SRNTBZFlj0SaGKlkLMCVyDvitvbM3WR3hxpNznPfqVklPsww+NNBwwKLW2OQBJPD6QPLZkz7q6p9MtcY32fbwckOqeiUq7rl+TA8S6N3cCdZLCQmQCwZXVSeWooTpz3Z51zwvo9c3CF4Y9ShtJYuiDVgHHbYZ2I99b65tgouUXOlrSVsNgntW4mCnA3IbT3c1B2qh6HXIMZtJIpASbidJQwCgx2xbSylTqz1PcRzrCeGMcijez3uvJvDPKWNyrdWqvwVqdCOIHlBnYnaWI7AZJ2fkBXP8C779SPtof99brgVwkRTKMzzpfxAhgqII7ZXyV0ksTrPeOVDwcPU2zzZOpWYDlpwpgXB78nrs5z9Dlvtsukhqa1cNLjuzF9ZPSnp5TfPZFZ0CsDqmtp7KIsjKTJOiAxuQcQSF8EI4RsMu6kZ5EkVvG+gN3FPIkcYeMMTG/XRdqNu0jHLDfSRnuznGa1V4vzJbHNLDfx0/KKj3KFHqAp+kw7cP8AZbT/AEEp4+k17X3fbwGTrHDeuy7+TCp0NvjygOxdcF4w2Y3aNgFLZOGRh7KduhV/+znOVGA8ZILMqKCA2R2mUb+Nem3+93ZNjz4oZD65ZJZD8WNNYfy64/rE/wDNtqyfTVG77X9TRdVcqrvX0s8n4p0eubdA80WlWOkMGRxqxnHYY42BqsxW26Tf+nr/AGlP9GSsTWObH6c3Hwb4cnqQUvIsUsUqVZmgsUqVKgBxVrVUKs6aBkCcVmA0iQgeA2ApR8VmXOlyMnJxtk+Jq5m4BAMaZg3uHt3rv+D1vv8AxhfV3mun7tk/bMF1ON77/wCCll4xO27OScYyd9vD1Vz8qzYA1nA5ejFWT8HiBI159ORTfJEX1z7xR91y/tletD9osOh97JIboO5b+Lg7/wBqtavUuXF5w8ajoW2mlK92YZb+QH/AKq+jVkkflJVs5txtkftVrV/YRwyZlw/WwWk0YOperKySuC2MZBxckc+6t1hn6Wl/N9KOSeWKz3+H62TSL/8AzFH/ALpj6e1FpP8Apj30XxmfRcW8rkkCR5vE6GunmAH/AGttVX5JF1Grtdb1azE6hp0m4kgxp05+ipzq7+VW95paXhhOCGjtsg75xJ1bA+1TXS61X7y/I41ag17R/MqLy6DeUyKxwtpIusjSTpt1hDEZONT4xv8ASArJdDL2RrkIzkr1N4cHl/JLijeJ3c06mOW5dkznQNCKSORYIBqx3Z5U/Rfh8aXGpWyepu9sj9knrlyYpykpVSSXfwd8HGEJJu27fHkvLVzrsxnYtxMkeqzix99SW88vkroI/mi/alwx0k9SSNjj6Efd3476axjUtatq3VuJ4Hj/ABOGibPHkEhz9KQe97D8K6IqpSb7yRxPeEa7RZFxCRtM0ecxRmwETd0iNHesZcfRyxYaeY04O4q0Nks15aRMMh7a2HMjfyUEHI8CAarL3Hk4Oea2XwPEqsJpdNzbsDutlEw9YsiRSgnGL33+Ic6lNePhA7K962e02IMaxxHPfpdyD7mA9lSMJ/LLjqMatTZ1dXjHWppx1u2rrOrxjfOMVxHGF4jpHLrzp/olyVP90ij+HYN/cjP01+F7b1c2luvl/UmCbpN/8v0MV0o/kA/tK/6MlYmt/wAWgV7EAnA8oU936l6zB4ZH9b4iuPqMEpZJSR6HS5IxxRTKanq0PD0+t91c+QJ9b7q5/u8zo9WJWUqsmsU+t91Rm0Xx+6k8MkP1IgQqyqDyZfGicVOhoNSYl4I519tOyfrecMZyviKUPBmYA9YgzjZm04z3UbNbHUIxbqH57Ptgd2anurVkXWbWMDfbXnlmq0oNTK1uBsAT1sXPGNXP0iobfhTPsHjHPm2OXfSa/jbGYgMHOBtkeBqaXisJQqLVAT9IE5HqqfhHucwS3FrJmCUqxGnXE3MEhiue/cD3Cr6PinEjy4gwyO+XT4HH/PCs9FxJQMdUvr9G3j6vjXXynH1DRGBNRJxLk6hk5o2B2briUc0dmb0S3XX+Sw/xrrSUbXPEGgA040jWxxnmufGseOmfEdv47Pty+cO3ft4b0LZ8QhQDNurkfSYnJ9eK4PEI9ZYQKAT5uTgbchQ6fAoprkr81PZXskLiSJ2R1zh1OCNQKnB9IJHtrSdE7OG/ultnkS2aTaN+q6xWfujPbXTkcjvk4HfRvEOjqR8UHCh2mLxxmcQnIMqhg4i6w5UBgc6hsCe6kkvJaM3N0jvGdJGuZS8erq2LnKawA2nwyAAfVU38Lr/IPlc2QCB2zyYqSPaVX+6KfpbwhLW8e3hn8oMZ0s6x9XiUEho1XU2cHAznnkd1bX8pPQy8W2tbqZopZcCKYxxdW6sRqUSsrFHK4ZdYVTyznbEhRhl6U3wZnF1NqYKGOs5ITVpB9A1Nj+ka7l6XcQYFWvJyCCpBc7qRgr6sHGKqTbtq0Y7WcY9NETcJnUZaNgPH1U6Ytg1Oll+FCi7mCgBQNZ2UDAHu2p26W35GDdzbFT555qwZT7GUH1gUHFwidgWEZwMHPrpzwW4HONhnx2ophaH4lx26uFCzTySKpyFZsgHGM48cVX5opeGylDIEOgc27uePvqd+BXIGTE2MZ5d1GlhaK7NKjYeETuAyxMQeRxtXA4dKWK6DkHBHgaKY7QLSoz5Km3+bO3Oh54GQ4YEH00qAjFWNVwq40U0JlT1rfWPvpdYfE++uKVKwHpqVT2VnJNIsUSM7scKqjJO2T7AAST3AE0DIKVaX+AfEf2f/AOWH/fTN0F4iASbYjGrPbjz2SQ22rJ80+6p1x8j0vwZyjYWt8dsOD/NwR8as7joVfRjVJBoXUiljJHhS7rGuoKxIGpgOW2a9TtPyd2qQeTusLsR25SyrMWOMujMfmtJxpjPMKdQ3OVLPHHvz9S4Y3J/7PG7a5jR1ddaspDKwIyrKchvWCBXu/E+MWRhj6RAr5Qtq0Sx5BPXu2hezzypMik96n0V4xd9ELpbua0iQzNCe0y9ldJAKuS2AuQRsTz2GalHQLiP7N7pIif8APVSmu9EaX4NX+TngltNMb8rK6WuqUiR49U86DWqAMQS2SGycDIG+9azojxC14nZcRtUNwnWO03WXMsZCzS9perKhSqhkDacd533rwe2t2kdURC7sQFVQWZieQAG5NaD+AfEf2f8A+WL/AH0SklyCi3wD3RSJmjmDiZMq2GBww5rkbEZ7xmrTo1wk3gkVBM5UqPzqIq68hF+cYZY4bYeBq26B9AWeaVrpUHUFB1LuoVndVkVnYHSUCsG0g5YnHINWq6V8PmtrNvIEgjMkqK/VDEjdfoiRkAbTE3JCCu2tiCCSaiWf4tK5+hUcPw6nx9Ty+8KQTPGzudGVKhw3bU7jWhKkeo91d28iPuPKT447XLGcU0vQfiCqWNucKCTiSIkAczgPmp5eA8UtUz1boNQTsMjsXc4VNKEkkttjHOtY5V5M3BkHWKCVJnC/QUjBJ79uRpMuMljckEZUbjA9OasH6NcXJBaIkjcapIsqfUX2NVPFrm+t5Opnd1cBTpLK3ZYZG65GCPTTWSL4E4SRJ5RqjAXr86hggnTpz2thXV51IlBAuAm+rPnFu7Bqqj4pMvmuV9A2FJ+KzHALk4ORnfB8RT1BQbcIDnquuB59rP7qBvJlZQBq1Dnnf1/GpbficmoBpWCk9o+vmaXEII8ao3ZySc5XHtzUyaFw1ZXiruqSrrVQimNFw22KZ69tW/Z6sn1b1VXCAMQDkA7GrfiPFZVICyo4xzRceO3xqnmkLMWPMnNOVdhKyOtt+Sj+UXH9mb43FsD8CR7axNbf8lH8ouP7Mf8AyLaubqf5M/6P8jo6f+bH+q/M9KliUICM5IBPLG5kAwMfzPHvoviPn/8AZN/mmrFdMLLiTyxmyaYIIFD9XN1QLddcEZ7S5OK0XCopVghWfV1whkEmo6m1gzatTZOTnvryvQjCEZp8uGx6frSnOUX2U9yzKAzS5GfnEPtW6hIPrBAPsoSKIFC2+QCR4dlolOftP8Pp2MH56X+mv/kxUPD+bb+i/wDqWtYuKkqf4/yNlJp2vwCmUdWrY3ITJ7zoa4C59QJA8M1JBGBLHjPnsDnfeOaSIkYHI9XnHdnvri4/NJ6h/nnrCdI+G8Ye6uGtmuBA0sugJcaFOHYNpTWPphu7c5rfFgjllu6pQ/Ixy5pYo7d3P8yh/JYoN9nwguCPQerIyPYSPbXrMdnqTKq7N2chRqGklxyAzzTnnvryn8ln8uA+tDOB6ym1epXFtsNaRPpxgOkchXXk7a1JAOg+jatevgnPVJNrTyuzsy6GbUKi0nffuie4t+0qY0lmjDbYOTBbLkjxwAPYKfhgHWpgHDIj4O5GuNZACQBnBI3x3ZpRxKrxBVVRrjOlVCLlo4GYhVAAySTt40uE/nIf6mH/AMdK5nFeqpfiiv7UbqT9Kvwyf97IbKLVIE+vqj+0Vk/+1Tjz5D/PlPtENyQffTWSAK8v0onhYeos2R7wvupoXyXbxMh98FyaxwOnFf8AZ/Rr9DbOr1P+i+qf6nENpqTKqzNk7KM7LoB2Az9Pn6PTXlP5VEIv8EEEQ2+xGCPmxzFeryQxtbqWSJmWSTz4kkIUrEOyXUgDOM+yvMvyjkQ3HzccS60i1ARqB+aQ+aoAG5zXf9nxgp7c6f7cnF18puO/Gow1KrVLxmMICpknHmDvaiOLu8QXsx9sNnsg50sefpr1tvJ5NlFVjwviTphA4Vc5JKg4z31F8pvt2Y9uXYG1G38+hFKqgL7t2RvsD7N6KTCSvZoBv4kB1CVXJJzgEe2ic0NLcnCYVc4+qPE0VqPh8KaQJUiqxSIreHoU/wD0/Rz2pv4Evj9Hnx3qtBPqexhK2v5KD/GZx3m2bA7zpnt2OPUqsfUDRC9CHxj5vPjvmg+M9HZrWPyhZAjRkENGSrg8sgjcHfurPLh1wcfKLxZtM1KuGenyTBkVQDq2HPOcFyMDGc9s+6iL2dS+oHUuZkJB7xLKjgHxBz8K8RfpfxEgg3tzg/8AWf8AGhOG8burcFYLiWJSclY5GVSdhkgHGcAb15q+z5U/j32rbwek+uja+Hbfv5PeIZwZHblqePAJ73uYQq+k5IFQRzgIVPMggHIwMtGxyMf9Me814rd9J76VCkl3O6HBKtKxBKkMpxnuIB9YFendDnmlsBcyXV4zhbli3lL6FMKuUVl786RzO+amXQtJLX5XHzbFR61OTenw+flNBM4KBcjUqxlh3qJGuChI7sgZFdwTK0qEDAUszZIOMySTOcgDCjWfYK8O4fxmdZzOs0yu3nOJW1sDjIZ85YbDn4Ct9a8TuJUw9xI6HmGkYg+sZ3rR/Z7bTUttu3ykx6xU1p337+QL8nvCxHcdZuCIZh70rdtcgx6d9WRvnbA1nlzz2/Huqr4TAqkMjlX+spwRnYjIq0eaf9fJ9ow+41v1PRTzS1KVbVwZ4OpjiWlxve+aJ7l9JRuekoCPBkig1IfAjvFLhjr1qY2VVRNznZUWJcnxJ0+1sVnbuR4dRildC250SEaj4kA7n11kuknGLnSNdzMcMrL862A6nKsBnmCMg91ZPoH6mrVtadV4VF/e16dad6au/Psejx3GF0frJAv923u5R/iiFd2bDceJKj0loLhVA9JJAHrrxSbpRfuRqvJ2KMHUmVjpcAqGG+xwzDPgxqK86S3sq6Jbqd1BDaWkYgMu6tz5g8jUR+z60/FwmuPN/wCwl11qW3NPnxX+j20XA6vR35JznbB0ZGPHsD315l+VP+VL/Vw/6SVTr0w4l3Xtz9s5/fQXEL2afEkrvLITgs5LsQAABk+6tem6SWGWpyvauKM+p6pZY0o1vfJLwmMmSI4zpy3x2+NT3ETNFIHGChLp6i2GoixgMUJblIwGAe4aqXlrKya1DawUbw87ciutq02jz9XxUZurPip+bi9X/wBVqyfo3rwYzkHw2xlyOR8BQPGIGGlACdORy8ABVJpoq02D2UYLx55Aaj6gSaO8oH1fhR/C+H9XEJHBBOjA5HGuptR8B76STluQ8iuiqbjd5t84+/xpm41ej9I/woQouV7EnL3+r0U0kQ37Mgxy7/fmrL2J245eDnM/vqG64pcyLoeV2U9xO21Dt1fi/wAKhY77E49NIdIbSa5p801IYqN4O+mZD/SHvVh++gqemnTsKtB/CIwXCnk2Vz6xt91aO14VcJ5rFh9UNg/GqHhdt1p6v6y7H+cCcfECttw3ginQ6RrtjOEBIPeGGN/vq4xthbrYM4KyE6JS0D93WAqrf0X5GtHNw5gmTIun62dseuq7itwBF89HDkA9pbcQk7bAsoH/AA1jzw6ODqp3yw1sXiOQoVj2e/mNuQHfWrikJTkwnizsxIg1y+LqDoH/AHHY1meIWc27SE7dxPKtzxSJZ8PGkIixsixlj343bUTzHurIcY4WI4ySoB7tgDz78VE4pcDTbW5QhAMlvQMAjfO/PeoKdzvXNZMDuOUryoqK+dV7Jxkn9xoWN8dwPrqZcMN9tzSEd3F7IwXLnv8Avozht8SNLEbadJPjq3oMwpgdr4iksCfX+Iqk2iXFNUWF9xp1YCNtl5+khs09zxaVAGVsF9ycZ8D30B5PGeb/ABFE3MKkKGOAORyNxgUPfkSioqiC84pMwXMjcj95q+1r4iqOW1jwvb7vEb70ToHjRuVsuEQsRqPzkm2w2zt4UNeT74WRmHeTtRlwWDORJ9I47PMeNDGyX9Z/hNVJOxJoApUWlmCTlsDxwd64mt8HC5I8cYqNLKtA9OBR9tw8kZINWNtZAfR2raHTykZzyxiVllwySTOlc4GdziohDvpOxzg+jxrYwQGLDLy7xXF7wVJXWVWx3kAed+FdL6Ooque5zrq1q34K63wk8OkYG3vO2feB769W4RaxSgFo1J5ZKgn3868sMGJcctx/z761/Q3jTMpQnDqSrekr3j11nkjpdm+CWpUX/S6BI40WKJSxO5AyVAGc+vOKzfFkZIkOktnuxnO3LBrTtIeZYZPPfB+PdU/EbrMahchl2GQMenB7/ZWL33OqNJUgLhHDYpLeOTq9JKjKAkAewHFZDp1FGi9XGqqTucADl6udauK9ZVJyMY338K874rfmafV9HUBnx33prdpMzm6TozltCGIXfJI//dqs4eFxgZJLHuHL0d1C8MYLJkb8wDVskGcY5ncnwBrbDjTVtHNmyNOrKCe2Kk7bfCoWO3tNa8ghSFAxyO2c1R8StVAzyJPh76nL02ndFYs2vkr1TOhfHb3muJUwSPAkVPaNhge8cvXT8RXt6vrb+3vrj7m17glHX/mR+r9wrmxsGkPLA235Dc4qTiiYCjwyPcBTTADm81fV+81pfksfrFqo4fYGZkX6OBqPgCauPk4eJobE5IEkvW7zGdW5PM58PRTSX7bbx0NMmCuYo+Xjz9JoW5k7tCg+itHInQmESXzb+bvXVm5LDI7xQNtAWYCtPaxADAro6eEpuzLNKMFVE1sOYx3599WEMYHdzoW3TfPoI9tGrXpxujz5bvckxjbuoWM9W2k+Yx2P1T4US7UzRhgVPKqq+CLrkreKxfOI48QD+6h5pDbXIl30SYDevxqwhbt9XJ3A4J+luMe3ah+JR5GibVp3xKACN+WoDdSDjflXJmx6ov8Ae51YMmmS/ext7WWOUDPs/H1UTe2qBe0AAPD7vVWE4Txl4kCPH1iD6cZyR7O/2GtNZ38cy6kYMBz8VPgQeRriSa2PTU/DK7jM2pdC7L7tvD1VlGUF0AGRq59xwcbejnvV3xW51kqoOnOAeWs/7fv9XMMqofU+AqgADPM4+NaYsLb1M5s2atkVNrZYkc4IAIAXlz5Ve20AHP200ERZjI3I40gjBAx+OffXdwcD11248aijhyZHJg9xIDy5Cqu6j17eG9WLQ5woqEQ+fjuIUewA5+JqZpy2KxyUdzPTQgV3byKcau7H31aXPDsjY71QuCp/53V52fE4M78U1NbMvX4sqbAeG3qNRSTQHBlViG5aTgjln4VTBCfD30ZcJqVQCOzz3HgKwS2opRSLf5bhhQLCjbjOSd9myM0/yk3hVJLaMQoyvL6w8TVj1R9HvFCVBpiVc+NsJjbx50O3qrpz6/bVhZWy4DMMk8gfCrjFzdIblpVsI4dGO7fHfVxAKEhbu5UZGcV6uKNI87NJthMZwT6cH9x+4e+pdXOgJrgLuSAPxoaLjCZGWGDnNaepGOzZkoSlukXSvnepA2KqE4nEDtIuD6eVStxSI/pFx6xVRyw8ol45eAzqRJq1egD0Hnt7xXKySR7N2l8e8VHBfxAfnEydz2h/z0eyp14hF+sT+8KFKL3sJKXFbHAhjbJRtDHnjbPrHf8AChooinzYIIAOt8+cvPSfHB9wOO+izcRc9Sf3hQwETSFsrywTq87vxz5d9ROMXXBeOclfJJHCWOoeGBnkB4n0n8Kmjs1Daj2m8T3eod1dNcr9Ye8U3WjxHvFaqMUZOUmSNQvnN6BTzTdwIyfTTBgowKbpi4OzgcqAtTtq7tTn/EQPgKIlbAzQFoewvhzPt3rObqSLgriyZ9xnxrPX9qQd+XjV/I3/ADwqvvFJHZx7a588VJHV08nFlDypaue1TXMTA5K4+6h68tqmd53q5bcqvfZVFG2Kv80ITKWBcmrS35eqhY1xRURrrxRoxnKwpeXpFTiShFeug9dKlRg4WDcaOQvrP7qpyKNvLrUSO4UGxrgzSUptnZjjpjRPwuyM08UIOkyyRxhjuFMjBckejNbC96BLGLePr1Mk8wUPpbAjMbOCF5fVzk5yRjYGsXbTtG6yIdLoyurDmrKQVPsIFeg8N8rlgjvJr6Qxr1kwRVQOrxrKmQz9nY6hvtg7Y2rE0K216ANJbRzmVYy0M0rLIDpHVsoAzgadnXJOefspcK6ACeFJlu0OqJJmTq2BVSZAV1bjIaKVc45r6as7u2u7oSW73xKGVoyGhPzmjqH1HtELiR4RgEZCk7kYMMvD7m1eGJb9gCJEUrCh0pBHK5Gkvk7zSjw7ZOc7UAO35K5NWFuUxgEdg7AuqkHcbqGVvTmhOCfk7aeKGYzqqSqjaQp1YMiRlc8gcuN8Ve3dhxCOFnN+/WCVc9ldJGuNFOMbNmOM8/o4xnNV3D1vYkhC3jJGElGOr1jNvdJCqAKA2li8Rzkkbn0UAV130B0vEFuVKStLhijdlIo3lZyOZOlDtgZJqef8m7xrMzShjHFcPhVIy0CQvpyQc56wju83nvVpxDhvEI3M7X2t7VXuUUple2JGkXZuR06d8jDEbd4/SN761tesN67kylByACsG1jG+e1nfPIDlyAB50KXtpYpUCH1HxNWPBJG14ztg7VW0fwg9v2H91a4X8aIyq4NF3cvsaAkO1TTSZFCyNXdklbOTHGkCTD3UEwo2ShpRXFkR1QZEa0GKz5rQVki2VqympBPXonSr8mISNp7WQ40F+ofc9ldTBJM5O2cAg8udeZwqW37s4zW0MtukTKFKwsT1Dd3e2BU8ulOyBk+JodoAd/uraeqqREaXILF3+ykane3K8++oK5GmuTVOzS2nRRPJIrye7SBJnkSNeqklYmM4OdA23Bq6PApba3Mj8TMVsspgQGCbLM0fWtmJlDIO2/nDfGe8VVdEeM37tBYQXCIhZtHWxRuiE6nZstGzDJBrYcQ4ZxmNSZL+By8sbMrwrJ25ngt1ftwkbF8EDGBHtnNSUDzdB+IRLP1XEQXVkOjtR9dJNGNIDHYOwOkZ5kLyOKoekNheR3FnDLes5uVilVyrL1fX/M7qRqzp2Iq5PCuMXIEb3i/xtHmYOmnPkkscSBcR5U7xsunTz8eZHEuhPFbmSK4mvIpJo2WOJipwNAeVN1TBYsBswzlxk8xSAG4h0S4ivlMZv9aQxyz5GorI8JDSxn9XIGZDg8w4YbZombodfdbKnypqmhVw6qj7a445HVfEFerOQMZA5EUPHbcSMF1cjiCOZ0AljRdPWHU9uNWYtKnTHJuuCdG5zirS54JxxmlJvrcs0TM8iwhXaMjB+cWEOOyB3ju8KYFRB0fu2v4uHycRcrPAJtQDDXGw7UWCDgmNGOWGNuWTvzc9H2njtbebiBD3jJPbo6yP824ZI1fSNAfBBJGMHV52QRY2FjxdZvJ14lbLLB1cKFogzFWhkkTTIYSxUxxyHc9x8ant+C8bCRsL21AjRdPzCFoUHcD1GQF7QwveNudIDC9N+iq2XVvHKZI5XuEUMMOptpBE4Y4APazggd1ZjFW/G+L3Ug8mnl1rDJMQCqgh2djI2rSGOpiTg+NVNUgEBXcUmkg1xT6M017CdFg02d6iaSoEXuzTMa3c9rMtG52zVGzVyWpVk5NlqNEbVoKoGFX1QNnv/Fm+Yx4wy/6Jr5tg5BdgNq+jeMkdWvj1M3j+pO9fN2eWaeFKOp+/6Eubm68f+/qTOe89/f6KdZMAmodVMzbEVvrJ0juxOSTk1DXScqjJrBs1RLBOyMGRmRhnDKSrDIIOCNxsSPbRj8duzsbqcgYIBmkOCCjA8+YMaH1ovgKrqmtrZ5DhFLEeHdS5ALfj12W1m6uC2/aM0hbcoTvqzuUQ/wDYvgKcdIbzb+N3GxyPn5NjnVnzueoZ9dB3dq8baXXBxnGQdj6vVUNDTTpgnatBfynPoMfXS6CMFOsbSRqL4K5wRrJb1knnRk3Se+di7Xc+onJIlddyACcKQM9lfcKqKVIA5eMXIJYXEwY6QWEr5IRSignOSAjMo8AxHfRLdI70kHyu4yAoBEzjAXTjkf5q7+gVUA0+qmM6dySSSSSSSSckk7kknmaampUCHqRaiFSZpoGLNNimJphTFQjSpE02akYz1p/IX8PjWYINaL5ei/Vye8fjQJnu17aSGN3YqQIpdIGQVBjIx6T6dq8EFrtyr6KvP5M/9S/+Q14VDdR4GcV09LGNM5c1wa09ylksfRQk1mR3GtassR7x76Gu1jxsRXRLFBmcc8kZIrgGoaMvBuaF0muCap0d0XasarzoldwxSs05ITTvjme0DgenFUdNUxlpaa7De6a8pr/JoeK3FvdXDN1phQRqFZkLa2XnsDtnJP8AzNB/J9vqA8qGNJJbq22bXgLg9xQhs5O4I8KqqVOUnJ2xRioqkW7cPttSr5VzJDN1Z0r+cIIBwe5BjfdjvtSbh9tqUC7GD5x6tuz2Cc741DUMY571UUqkotZrG2GMXOrxxG2x0E8zjI1jT7QaF4hDGj6YpOsXHn6Sudz3Hltj30JT0AKnpqVAjqnOa5BoiGrirE3RGENdCGjBT59FarGiNTBBFT9VRJauS1PShWQaKbq6lLU2aWwHtt1+Yf8Aq2/yGvGxSpUsfcJdhmqNqVKqYI4emFKlUPkohfnTClSrF8lipUqVAxqenpUCGpGnpUAMaVPSoAYVLHT0qqHIpEwpGlSrUyfIxrmlSpDGalSpUMpn/9k="));
            books b = new books();
            foreach (books i in book)
            {
                if (i.Id == id)
                {
                    b = i;
                    break;
                }
            }
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, string name, string author, string image)
        {
            var book = new List<books>();
            book.Add(new books(1, "Tuổi Trẻ Đáng Gía Bao Nhiêu?", "Rosie Nguyễn", "https://cdn0.fahasa.com/media/flashmagazine/images/page_images/tuoi_tre_dang_gia_bao_nhieu_tai_ban_2018/2019_11_05_09_19_54_1.jpg"));
            book.Add(new books(2, "Đừng chạy theo số đông", "Kiên Trần", "https://www.netabooks.vn/Data/Sites/1/Product/35663/dung-chay-theo-so-dong.jpg"));
            book.Add(new books(3, "LẬP TRÌNH VÀ CUỘC SỐNG", "Jeff  Atwood (dịch giả: Hồ Sỹ Hùng)", "data:image/jpeg;base64,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"));
            if (id == null)
            {
                return HttpNotFound();
            }
            foreach (books b in book)
            {
                if (b.Id == id)
                {
                    book.Remove(b);
                    break;
                }
            }
            return View("booksModel", book);
        }
    }
}