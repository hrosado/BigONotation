
// Rule 1: O(N)
Integer: FindLargest (Integer: array[])
    Integer: largest = array[0]
    For i = 1 to <largest index>
        If (array[i] > largest) then largest = array[i]
    Next i
    Return largest
End FindLargest


// Rule 2: 
Integer: FindLargest (Integer: array[])
    Integer: largest = array[0]                             // O(1)
    For i = 1 to <largest index>                            // O(N)
        If (array[i] > largest) then largest = array[i]
    Next i
    Return largest                                          // O(1)
End FindLargest

// Rule 3: No code provided

// Rule 4: 
Boolean: ContainsDuplicates (Integer array[])
    // Loop over all of the array's items
    For i = 0 To <largest index>
        For j = 0 T0 <largest index>
            // See if these two items are duplicates
            If (i != j) then
                If(array[i] == array[j]) Then Return True
            End If
        Next j
    Next index
    // If we get to this point, there are no duplicates
    Return False
End ContainsDuplicates


// Constant - O(1) function
function constantFunc(arr){
    console.log(1000 * 100000);                         // O(1)
}

// Constant - Big O(1) Example
function linearFunc(arr){
    for (let i = 0; i < arr.length; i++){               // O(n)
        console.log(1000 * 100000);                     // O(1)
        let something = (2000000000 * 2000000000) / 2;  // O(1)
        console.log(something)                          // O(1)
    }
}