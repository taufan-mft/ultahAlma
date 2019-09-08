Module Module1

    Sub Main()
        authentication

    End Sub

    Sub authentication()
    Console.WriteLine("Hai, aku Taufan. I'll give you some questions, and if you can answer all of it, you can read my message.")
    Console.WriteLine("Cara mainnya: jawab pertanyaan aku dengan mengetik jawabannya tidak pakai huruf besar lalu kemudian tekan enter untuk OK. Jika salah kamu akan kembali ke awal.")
    Console.Write("Paham? (ya / tidak): ")
    Dim ya as String = Console.ReadLine()
    Console.Write("Oke, first, siapa nama kamu? (satu kata saja): ")
    Dim nama as String = Console.ReadLine()
    If nama <> "fawnia"
        Console.WriteLine("SALAH!")
      authentication()
    End If
    Console.Write("Hmm, baiklah. Tapi aku belum yakin. Mama kamu biasa manggil aku apa? (dua kata): ")
    Dim jawaban as String = Console.ReadLine()
    If jawaban <> "mas topan"
      Console.WriteLine("SALAH! Kata pertama depannya m")
      Console.WriteLine("------------------------------")
      authentication()
      End If
    Console.Write("Sekali lagi deh. Tanggal jadian kita berapa ya? (dd-mm-yyyy)")
    jawaban = Console.ReadLine()
    If jawaban <> "09-09-2017"
    Console.WriteLine(SALAH! Formatnya bener ga?)
    Console.WriteLine("-------------------------")
    Console.WriteLine("")
    authentication
    End Sub

End Module
Module Module1

    Sub Main()
        authentication

    End Sub

    Sub authentication()
    Console.WriteLine("Hai, aku Taufan. I'll give you some questions, and if you can answer all of it, you can read my message.")
    Console.WriteLine("Cara mainnya: jawab pertanyaan aku dengan mengetik jawabannya tidak pakai huruf besar lalu kemudian tekan enter untuk OK. Jika salah kamu akan kembali ke awal.")
    Console.Write("Paham? (ya / tidak): ")
    Dim ya as String = Console.ReadLine()
    Console.Write("Oke, first, siapa nama kamu? (satu kata saja): ")
    Dim nama as String = Console.ReadLine()
    If nama <> "fawnia"
        Console.WriteLine("SALAH!")
      authentication()
    End If
    Console.Write("Hmm, baiklah. Tapi aku belum yakin. Mama kamu biasa manggil aku apa? (dua kata): ")
    Dim jawaban as String = Console.ReadLine()
    If jawaban <> "mas topan"
      Console.WriteLine("SALAH! Kata pertama depannya m")
      Console.WriteLine("------------------------------")
      authentication()
      End If
    Console.Write("Sekali lagi deh. Tanggal jadian kita berapa ya? (dd-mm-yyyy)")
    jawaban = Console.ReadLine()
    If jawaban <> "09-09-2017"
    Console.WriteLine(SALAH! Formatnya bener ga?)
    Console.WriteLine("-------------------------")
    Console.WriteLine("")
    authentication
    End Sub

End Module
