# TwitterApiUCU
Api para publicar en twitter de la UCU

Para utilizar esta libreria se debera agregar una referencia a su proyecto y luego invocar el siguiente código:

```c#
var twitter = new TwitterImage(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
Console.WriteLine(twitter.PublishToTwitter("text",@"PathToImage.png"));
```

Las credeciales podran ser descargadas de Webasignatura
