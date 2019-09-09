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
        Console.Write("Sekali lagi deh. Tanggal jadian kita berapa ya? (dd-mm-yyyy)")
        jawaban = Console.ReadLine()
        If jawaban <> "09-09-2017" Then
            Console.WriteLine("SALAH! Formatnya bener ga?")
            Console.WriteLine("-------------------------")
            Console.WriteLine("")
            authentication()
        End If
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

End Module
