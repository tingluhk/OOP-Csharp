using System.Collections.Generic;

class IndexerSample{
    public Dictionary<string,string> _dictionary = new Dictionary<string, string>();

    public IndexerSample(){
    }

    public string this[string key]{
        get{return _dictionary[key];}
        set{this._dictionary[key] = value;}
    }
}