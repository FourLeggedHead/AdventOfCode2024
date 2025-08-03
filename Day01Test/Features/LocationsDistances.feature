Feature: Locations Distances

  Background:
    Given the first list of location IDs is:
      | Location IDs |
      |            3 |
      |            4 |
      |            2 |
      |            1 |
      |            3 |
      |            3 |
    And the second list of location IDs is:
      | Location IDs |
      |            4 |
      |            3 |
      |            5 |
      |            3 |
      |            9 |
      |            3 |

  Scenario: The distance between the smallest location IDs
    Given the 1st smallest location ID in the first list is 1
    And the 1st smallest location ID in the second list is 3
    When I calculate the distance between the two location IDs
    Then the distance should be 2

  Scenario: The distance between the 2nd smallest location IDs
    Given the 2nd smallest location ID in the first list is 2
    And the 2nd smallest location ID in the second list is 3
    When I calculate the distance between the two location IDs
    Then the distance should be 1

  Scenario: The distance between the 3rd smallest location IDs
    Given the 3rd smallest location ID in the first list is 3
    And the 3rd smallest location ID in the second list is 3
    When I calculate the distance between the two location IDs
    Then the distance should be 0

  Scenario: The distance between the 4th smallest location IDs
    Given the 4th smallest location ID in the first list is 3
    And the 4th smallest location ID in the second list is 4
    When I calculate the distance between the two location IDs
    Then the distance should be 1

  Scenario: The distance between the 5th smallest location IDs
    Given the 5th smallest location ID in the first list is 3
    And the 5th smallest location ID in the second list is 5
    When I calculate the distance between the two location IDs
    Then the distance should be 2

  Scenario: The distance between the 6th smallest location IDs
    Given the 6th smallest location ID in the first list is 4
    And the 6th smallest location ID in the second list is 9
    When I calculate the distance between the two location IDs
    Then the distance should be 5

  Scenario: The total distance between the 2 lists
    When I calculate the total distance between the two lists
    Then the total distance should be 11
