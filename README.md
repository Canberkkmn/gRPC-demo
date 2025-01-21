# gRPC-demo

A chat system with a twist. Users can chat with each other similar to regular chat rooms. In addition, a special bot sends news flashes
to the chat room, making users aware of important events happening in the world.

A special monitoring console displays the events sent allowing admins to eversee the bot and users activity.

It has three main components:

1. **Chat Room**: Where users can chat with each other and register for the chat room they're interested in.
2. **News Bot**: A bot that sends news flashes to the chat room.
3. **Admin Console**: A monitoring console that displays the events sent by the bot and the users' activity.

## Architecture

<img width="624" alt="image" src="https://github.com/user-attachments/assets/b31241b9-3bfc-4d0f-a245-c3da30afad3b" />

## How to run

1. Clone the repository.
2. Run the following command in groomserver:

```bash
dotnet restore
dotnet build
dotnet run
```

3. Run the following command in groomadmin:

```bash
dotnet restore
dotnet build
dotnet run
```

4. Run the following command in fullroomclient:

```bash
dotnet restore
dotnet build
dotnet run
```

5. Go to fullroomclient/publish folder and run fullroomclient.exe

- Now you have 3 users (terminals). Admin, fullroomclient and fullroomclient.exe users.
- Register fullroomclients to same room with different usernames.
- Send message from one of the fullroomclients. You should see the message in other fullroomclient and in groomadmin.

6. Run the following command in newsbot:

```bash
node client.js
```

7. You should see the news in groomadmin and fullroomclient. Please note that you won't see the duplicated news.
