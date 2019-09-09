Module Module1

    Sub Main()
        initial()

    End Sub

    Sub authentication()
        Console.WriteLine("Hai, aku Taufan. I'll give you some questions, and if you can answer all of it, you can read my message.")
        Console.WriteLine("Cara mainnya: jawab pertanyaan aku dengan mengetik jawabannya tidak pakai huruf besar lalu kemudian tekan enter untuk OK. Jika salah kamu akan kembali ke awal.")
        Console.Write("Paham? (ya / tidak): ")
        Dim ya As String = Console.ReadLine()
        Console.Write("Oke, first, siapa nama kamu? (satu kata saja): ")
        Dim nama As String = Console.ReadLine()
        If nama <> "fawnia" Then
            Console.WriteLine("SALAH!")
            authentication()
        End If
        Console.WriteLine("....")
        Threading.Thread.Sleep(3000)
        Console.Write("Hmm, baiklah. Tapi aku belum yakin. Mama kamu biasa manggil aku apa? (dua kata): ")
        Dim jawaban As String = Console.ReadLine()
        If jawaban <> "mas topan" Then
            Console.WriteLine("SALAH! Kata pertama depannya m")
            Console.WriteLine("------------------------------")
            authentication()
        End If
        Threading.Thread.Sleeo(3000)
        Console.Write("Sekali lagi deh. Tanggal jadian kita berapa ya? (dd-mm-yyyy): ")
        jawaban = Console.ReadLine()
        If jawaban <> "09-09-2017" Then
            Console.WriteLine("SALAH! Formatnya bener ga?")
            Console.WriteLine("-------------------------")
            Console.WriteLine("")
            authentication()
        End If
        welcome()
    End Sub

    Sub initial()
        Console.WriteLine("---------------------------------")
        Console.WriteLine("Topan's Late Anniversay Saver")
        Console.WriteLine("---------------------------------")
        Console.WriteLine("")
        Console.WriteLine("Please wait, connecting to server...")
        Threading.Thread.Sleep(5000)
        Console.WriteLine("CONNECTED!")
        Console.WriteLine("")
        authentication()
    End Sub

    Sub welcome()
      Console.WriteLine("Congratulation, you've verified yourself!")
      Console.WriteLine("")
      Console.WriteLine("-----------------------------------")
      Console.WriteLine("Topan's Late Anniversary Saver")
      Console.WriteLine("-----------------------------------")
      Console.WriteLine("")
      Console.WriteLine("")
      Console.WriteLine("Welcome, Princess Alma Arabella!")
      Console.WriteLine("What would you like to know first?")
      Console.WriteLine("")
      Console.WriteLine("1. Sebuah pesan dari Topan untuk Alma")
      Console.WriteLine("2. Where do we go next?")
      Console.Write("Please enter the number (1 or 2): ")
      Dim nomor As String = Console.ReadLine()
      If nomor = 1
        pesan()
      ElseIf nomor = 2
        place()
      Else
        Console.WriteLine("Waduh gada pilihannya, ulangin.")
        welcome()
      End If

      Sub pesan()
      Console.WriteLine("Oke, I'm going to give my message to you. If ready, please press Enter.")
      Console.ReadLine()
      Console.WriteLine("-----------------------------------------------------------------------")
      Console.WriteLine("Hai, Fawnia Alma!")
      Console.WriteLine("SEKARAANG TANGGAL 9 SEPTEMBER!!!!!")
      Console.WriteLine("HAPPY ANNIVERSARY SAYANGGG!! hehehe")
      Console.WriteLine("")
      Console.WriteLine("Please press Enter:")
      Console.ReadLine()
      Console.WriteLine("Honestly, ingatan aku nembak kamu tuh masih terasa seperti kemarin. Ga kerasa aja udah 2 taun. Thankyou for everything that you have done sampe kita masih bisa bareng disini sekarang. Walopun kadang aku nyebelin banget, kamu juga kadang nyebelin banget, tapi aku bersyukur kita masih bareng sampe sekarang. Tau ga apa yang paling Topan suka dari Alma selama 2 taun ini? Topan paling suka kalo Alma ngelendot gitu sambil meluk heheh. ")
      Console.WriteLine("But I love every little thing that you do, your smile, your laugh, kamu ngucir rambut. Baumu juga aku sukaa!!!!
Mau ngomong apalagi ya….
Oiya im so sorry kita gabisa dinner hari ini. Makanya aku kasih app ini namanya late anniv saver wwkwk")
      Console.WriteLine("All in all, inget ya aku bersyukur punya kamu, bisa sama kamu, im glad that youre exist. Because the world will absolutely feel different without you. Looking forward to spend the rest of my life with youu..")
      Console.WriteLine("")
      Console.WriteLine("I love you Alma, forever and always.")
      Console.WriteLine("")
      Console.WriteLine("Dari,")
      Console.WriteLine("Topan")
      Console.WriteLine("")
      Console.WriteLine("This is the end of the message, my lady.")
      Console.Write("Sudah ngeliat opsi nomer 2 belum, beb? (sudah / belum): ")
      Dim sudah3 As String = Console.ReadLine()
      If sudah3 = "sudah"
        Console.WriteLine("Oke, please call Topan at his WhatsApp, he's been wondering if u can solve this wkwkw")
        Console.WriteLine("Tekan apasaja untuk keluar...")
        Console.ReadKey()
      ElseIf sudah3 = "belum"
        place()
      Else
          Console.WriteLine("Gada opsinya, ulangin ya")
          pesan()
      End If
      End Sub

    Sub place()
      Console.WriteLine("Nanti hari Jumat kita dinner ya, aku kasih kamu pilihan tempat:")
      Console.WriteLine("1. Ambalika Java Heritage Rooftop poolside")
      Console.WriteLine("2. Tepi Jalan")
      Console.WriteLine("3. Table Nine")
      Console.WriteLine("4. Korea Garden")
      Console.WriteLine("5. Red Chili")
      Console.WriteLine("Kalau udah milih, please call Topan at his WhatsApp after u finish this program.")
      Console.WriteLine("Udah liat opsi nomer 1 belum, beb? (sudah / belum): ")
      Dim sudah3 As String = Console.ReadLine()
      If sudah3 = "sudah"
        Console.WriteLine("Oke, please call Topan at his WhatsApp, he's been wondering if u can solve this wkwkw")
        Console.WriteLine("Tekan apasaja untuk keluar...")
        Console.ReadKey()
      ElseIf sudah3 = "belum"
        pesan()
      Else
          Console.WriteLine("Gada opsinya, ulangin ya")
          place()
      End If



End Module
