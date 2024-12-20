# How (Auto vs *) Works in View.xaml								
<ColumnDefinition Width="Auto"/> (Content-Based Sizing)
Behavior: The column's width is automatically adjusted to fit the size of its content.
Use Case: Best for layouts where the column size should match its content's size exactly.


<ColumnDefinition Width="*"/> (Proportional Sizing)
Behavior: The column takes up a proportion of the remaining available space in the Grid.
Use Case: Best for responsive layouts where the column size should scale dynamically with the window or parent container.


https://stackoverflow.com/questions/23259173/unexpected-character-encountered-while-parsing-value
Resolve an error in the json because of encoding set