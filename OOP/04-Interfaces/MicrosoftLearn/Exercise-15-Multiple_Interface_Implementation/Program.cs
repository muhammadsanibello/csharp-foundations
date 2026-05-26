using Exercise_15_Multiple_Interface_Implementation;

SuperCar superCar = new SuperCar();
superCar.Drive();
superCar.Fly();

var musicPlayer = new MusicPlayer();
musicPlayer.Play();
musicPlayer.Pause();
Console.WriteLine(musicPlayer.IsPlaying);
musicPlayer.SkipToNext();
musicPlayer.AdjustVolume(50);