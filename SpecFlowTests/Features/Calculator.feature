Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowTests/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario Outline: Add two numbers permutation
    Given the first number is <First number>
    And the second number is <Second number>
    When the two numbers are added
    Then the result should be <Expected result>
Examples:
    | First number | Second number | Expected result |
    | 0            | 0             | 0               |
    | -1           | 10            | 9               |
    | 6            | 9             | 15              |


	
Scenario: Subtract two numbers
	Given the first number is 150
	And the second number is -70
	When we find difference of the two numbers
	Then the result should be -220

Scenario Outline: Subtract two numbers permutation
    Given the first number is <First number>
    And the second number is <Second number>
    When we find difference of the two numbers
    Then the result should be <Expected result>
Examples:
    | First number | Second number | Expected result |
    | 0            | 0             | 0               |
    | -1           | 10            | 11              |
    | 6            | 9             | 3              |



Scenario: Multiply two numbers
	Given the first number is 5
	And the second number is 4
	When the two numbers are multiplied
	Then the result should be 20

Scenario Outline: Multiply two numbers permutation
    Given the first number is <First number>
    And the second number is <Second number>
    When the two numbers are multiplied
    Then the result should be <Expected result>
Examples:
    | First number | Second number | Expected result |
    | 0            | 0             | 0               |
    | -1           | 10            | -10             |
    | 6            | 9             | 54              |


Scenario: Divide two numbers
	Given the first number is 15
	And the second number is 5
	When the division is done
	Then the result should be 3

Scenario Outline: Divide two numbers permutation 
    Given the first number is <First number>
    And the second number is <Second number>
    When the division is done
    Then the result should be <Expected result>
Examples:
    | First number | Second number | Expected result |
    | 6            | 2             | 3               |
    | 18           | 9             | 2               |
    | 20           | 4             | 5               |

Scenario: Divided By Zero
	Given the first number is 0
	And the second number is 5
	When Divided By Zero
	Then the result should be 0

Scenario Outline: Divided By Zero permutation 
    Given the first number is <First number>
    And the second number is <Second number>
    When Divided By Zero
    Then the result should be <Expected result>
Examples:
    | First number | Second number | Expected result |
    | 2            | 6             | 3               |
    | 0            | 9             | 0               |
    | 0            | 4             | 0               |

