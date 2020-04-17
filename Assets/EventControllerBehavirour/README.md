Como usar:
- Coloque o App na cena
- Crie os enums com os eventos que seu game vai precisar
- Como chamar um evento:      App.Notify(eventToCall, new object[] { message });
- Para tratar um evento a classe deve herdar de EventController<T> sendo T o tipo enum usado nos eventos desse controller. Override NotifyController para tratar os eventos;
