# Resize Matrix Column
Fast function to add or remove columns of a multidimensional array. This function uses Array.Copy function to copy a range of elements into the new array, instead of copying each element one by one. 

Given a multidimensional array, matrix1 :
```
1 1 1 1 
2 2 2 2 
3 3 3 3
```

To re-build the array into 6 columns and split the columns at index 2, call the function
ResizeMatrixColumn(matrix1, 6, 2)

The return array will be,
```
1 1 0 1 1 0 
2 2 0 2 2 0 
3 3 0 3 3 0
```
