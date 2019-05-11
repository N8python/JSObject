class JSObject {
  private List<dynamic[]> matches;
  public dynamic this[dynamic key]{
    get {
      foreach (dynamic match in matches) {
        if(match[0] == key){
          return match[1];
        }
      }
      return null;
    }
    set {
      foreach (dynamic match in matches) {
        if(match[0] == key){
          match[1] = value;
          return;
        }
      }
      matches.Add(new dynamic[] {key, value});
    }
  }
  public JSObject(List<dynamic[]> matches){
    this.matches = matches;
  }
  public JSObject(){
    this.matches = new List<dynamic[]>();
  }
}
