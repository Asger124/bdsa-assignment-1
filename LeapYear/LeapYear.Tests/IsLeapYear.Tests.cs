namespace LeapYear.Tests; 

 public class LeapUnitTest1
{
    [Fact]
     public void is4LeapYear()
    {
        // Given
        var sut = new LeapYearcalc(); 

    
        // When
       var result = sut.isLeapYear(4);
    
        // Then
        result.Should().Be(true); 

    }

[Fact]
public void is100LeapYear()
{
    // Given
    var sut = new LeapYearcalc(); 

    // When
    var result = sut.isLeapYear(100); 


    // Then
    result.Should().Be(false); 
}



[Fact]
public void is400LeapYear()
{
    // Given
    var sut = new LeapYearcalc();

    // When
    var result = sut.isLeapYear(400); 

    // Then
    result.Should().Be(true); 
}
}

