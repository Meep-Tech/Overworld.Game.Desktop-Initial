using Overworld.Controllers.SimpleUx;
using Simple.Ux.Data;
using UnityEngine;

public class Test_SimpleUx : MonoBehaviour {
  ViewController _view;

  // Start is called before the first frame update
  void Start() {
    var testModel = new ViewBuilder("Test")
          .AddField(new TextField("Test Text"))
          .AddHeader(new Title("Test Header"))
          .AddField(new ToggleField("Test Toggle"))
          .AddField(new ToggleField("Test Toggle", dataKey: "toggle2"))
      .StartNewPannel(new("Pannel 2"))
          .AddField(new ReadOnlyTextField("this is just some text  and more and more and more and more and more and more and more and more"))
          .AddField(new RangeSliderField("Test Slider", 0.5f, 1.4f))
        .StartNewColumn()
          .AddField(new TextField("Test Text 2"))
          .AddField(new TextField("Test Text 3"))
          .AddField(new TextField("Test Text 4"))
    .Build();

    _view = SimpleUxViewWindowsManager.Current.OpenView(testModel);

    /*testModel = new ViewBuilder("Test2")
      .AddField(new TextField("Test Text"))
      .AddField(new ToggleField("Test Toggle"))
      .StartNewColumn(new Title("Test Col", "Tooltip for test col title"))
      .AddField(new TextField("text description", value: "this is just some text", isReadOnly: true))
      .AddField(new ToggleField("Test Toggle", dataKey: "toggle2"))
    .Build();

    SimpleUxViewWindowsManager.Current.OpenView(testModel);

    testModel = new ViewBuilder("Test smol")
      .AddField(new TextField("Test Text"))
    .Build();

    SimpleUxViewWindowsManager.Current.OpenView(testModel);

    testModel = new ViewBuilder("Test3")
      .AddField(new TextField("Test Text"))
      .AddField(new ToggleField("Test Toggle"))
      .StartNewColumn(new Title("Test Col", "Tooltip for test col title"))
      .AddHeader(new Title("Test Header"))
      .AddField(new ToggleField("Test Toggle", dataKey: "toggle2"))
      .StartNewPannel(new Pannel.Tab("pannel 2", tooltip: "pannel 2 tooltip"))
      .AddField(new TextField("Other Pannel Field"))
    .Build();

    SimpleUxViewWindowsManager.Current.OpenView(testModel);

    testModel = new ViewBuilder("Test4")
          .AddField(new TextField("Test  ff f f f Text"))
          .AddField(new TextField("text description", value: "this is just some text. and more and more and more and more and more and more and more and more ", isReadOnly: true))
          .AddField(new ToggleField("Test Toggle"))
          .AddField(new RangeSliderField("Test Slider", 0, 1))
          .AddField(new RangeSliderField("Test Slider 1", 0.5f, 1.4f))
          .AddField(new RangeSliderField("Test fffffff Slider clamped", 0, 1, true))
        .StartNewColumn(new Title("Test Col", "Tooltip for test col title"))
          .AddField(new ReadOnlyTextField("this is just some text  and more and more and more and more and more and more and more and more"))
          .AddField(new ToggleField("Test fd sdf sg sdg  Toggle", dataKey: "toggle2"))
          .AddField(new RangeSliderField("Test  ff ff Slider4", 0.5f, 1.4f, isReadOnly: true, value: 1f))
      .StartNewPannel(new Pannel.Tab("pannel 3", tooltip: "pannel 2 tooltip"))
          .AddField(new TextField("text description", value: "this is just some text. andre and more ", isReadOnly: true))
          .AddField(new TextField("Other Pannel Field"))
          .AddField(new TextField("text description", value: "this is just some text. and more nd more and more and more and more andnd more and more and more and more andand more and more and more and more and more and more and more ", isReadOnly: true))
      .StartNewPannel(new Pannel.Tab("pannel 4", tooltip: "pannel 2 tooltip"))
          .AddField(new ReadOnlyTextField("this is just some text. andre and more "))
          .AddField(new ToggleField("Test Toggle 5"))
          .AddField(new ReadOnlyTextField("this is just some text. and more nd more and more and more and more andnd more and more and more and more andand more and more and more and more and more and more and more "))
      .StartNewPannel(new Pannel.Tab("pannel 5", tooltip: "pannel 2 tooltip"))
          .AddField(new TextField("Other Pannel Field3"))
      .StartNewPannel(new Pannel.Tab("pannel 6", tooltip: "pannel 2 tooltip"))
          .AddField(new TextField("Other Pannel Field4"))
      .StartNewPannel(new Pannel.Tab("pannel 7", tooltip: "pannel 2 tooltip"))
          .AddField(new TextField("Other Field5"))
          .AddField(new TextField("Other Field6"))
          .AddField(new TextField("Other ff f f f f ff f f f f f f  f f f f f f f Field7"))
          .AddField(new TextField("Other Field84"))
          .AddField(new TextField("Other Field9"))
          .AddField(new TextField("Other Field10"))
          .AddField(new TextField("Other Pannel Field11"))
          .AddField(new TextField("Other Pannel Field543"))
          .AddField(new TextField("Other Pannel Field556"))
          .AddField(new TextField("Other Pannel Field5t"))
          .AddField(new TextField("Other Pannel Field5gfdh"))
        .StartNewColumn(new Title("Test Col", "Tooltip for test col title"))
          .AddField(new TextField("Other Fisdfgeld5"))
          .AddField(new TextField("Other Fsdfguuield6"))
          .AddField(new TextField("Other fdfgf f f f f uff f f f f f f  f f f f fgfgf f f Field7"))
          .AddField(new TextField("Other Field8"))
          .AddField(new TextField("Other Fdfgigsdfeld9"))
          .AddField(new TextField("Other Fidsfgtyukyukseld10"))
          .AddField(new TextField("Other Panneukyukyukl Field11"))
          .AddField(new TextField("Other Padgssdffgnnel Field543"))
          .AddField(new TextField("Other Pdffggannel Fieldtyukyt556"))
          .AddField(new TextField("Other Psdsdtyukfgadfgsdfnnel Field5t"))
          .AddField(new TextField("Other dfgsdfgPannel Field5gfdh"))
          .AddField(new TextField("Other gsdfgsdfgField5"))
          .AddField(new TextField("Other Fdfgtyukield6"))
          .AddField(new TextField("Other fffyukgsdgf f f f f ff f f f f f f  f f fdfgdfg f f f f Field7"))
          .AddField(new TextField("Other Fdfgsield8"))
          .AddField(new TextField("Other Fisuktdftyuktygeld9"))
          .AddField(new TextField("Other Fisuktydeld10"))
          .AddField(new TextField("Other tyuk Field11"))
          .AddField(new TextField("Other Panntyukelfgdf Field543"))
          .AddField(new TextField("Other Pttkuyukyannel tyFieljhkd556"))
          .AddField(new TextField("Other Pukannekul Field5t"))
          .AddField(new TextField("Otheruk kPannel Fytukiteld5gfdh"))
    .Build();

    _view = SimpleUxViewWindowsManager.Current.OpenView(testModel);*/
  }

  void Update() {
    Debug.Log(_view?.Data?.GetFieldValue("Test Slider"));
  }
}
