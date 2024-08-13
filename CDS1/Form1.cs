// Lewis Cottrill
// Complex Data Structures AT1
// 9/08/2024

using Galileo6; // 3rd party library imported for raw data
using System.Diagnostics; 

namespace CDS1
{
	public partial class Form1 : Form
	{
		private ReadData readData;
		private LinkedList<double> sensorAData; // Create LinkedList in double type
		private LinkedList<double> sensorBData;
		public Form1()
		{
			InitializeComponent(); // Initialize
			readData = new ReadData();
			sensorAData = new LinkedList<double>(); // Initialize new LinkedLists
			sensorBData = new LinkedList<double>();
			numericUpDownMu.Value = 0; // Set value of numericUpDown swtiches
			numericUpDownSigma.Value = 1;
		}
		private void FillLinkedListsWithSensorData(double mu, double sigma) // Method to Fill LinkedList with data from sensor with mu and sigma as parameters
		{
			sensorAData.Clear(); // Clear sensorAData
			sensorBData.Clear();

			for (int i = 0; i < 1000; i++) // Repeat 1000 times to load 1000 pieces of data
			{
				double valueA = readData.SensorA(mu, sigma); // calls SensorA with arguments mu and sigma, assigning the result to valueA
				double valueB = readData.SensorB(mu, sigma);
				sensorAData.AddLast(valueA); // Adds valueA as the last element in the sensorAData LinkedList
				sensorBData.AddLast(valueB);
			}
		}
		private void FillListBoxWithSensorAData() // Fills ListBox with the sensorA data
		{
			listBoxSensorA.Items.Clear(); // Clear items from ListBox
			foreach (var value in sensorAData) // For each value in sensorA data, add to ListBox
			{
				listBoxSensorA.Items.Add(value);
			}
		}
		private void FillListBoxWithSensorBData() // Fills ListBox
		{
			listBoxSensorB.Items.Clear(); // Clear ListBox
			foreach (var value in sensorBData) // For each value in sensorB data, add to ListBox
            {
				listBoxSensorB.Items.Add(value);
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
		}
		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
		private void numericUpDownSigma_ValueChanged(object sender, EventArgs e)
		{
		}
		private void numericUpDownMu_ValueChanged(object sender, EventArgs e)
		{
		}
		private void buttonLoadSensorData_Click(object sender, EventArgs e) // Button for loading sensor data
		{
			double mu = (double)numericUpDownMu.Value; // mu becomes the value of the numericUpDown switch
			double sigma = (double)numericUpDownSigma.Value; // sigma becomes the value of the numericUpDown switch
            FillLinkedListsWithSensorData(mu, sigma); // Call fill method with arguments mu and sigma for LinkedLists
			FillListBoxWithSensorAData(); // Call fill method for ListBox
			FillListBoxWithSensorBData(); // Et cetera 
			FillListViewWithSensorData(); 
		}
		private void FillListViewWithSensorData() // Method for filling ListView with data from sensor
		{
			if (sensorAData.Count != sensorBData.Count) // If sensorA data is not equal to sensorB
			{
				MessageBox.Show("The number of items in the LinkedLists does not match."); // Alert user of catastrophic computing failure
				return;
			}

			listView.Items.Clear(); // Clear ListView items
			var nodeA = sensorAData.First; // Assigns the first node of sensorA LinkedList to variable nodeA, this node contains the first data element in the list.
			var nodeB = sensorBData.First;

			while (nodeA != null && nodeB != null) // If nodeA not null and nodeB not null
			{
				ListViewItem item = new ListViewItem(nodeA.Value.ToString()); // Creates a new ListViewItem representing value stored in nodeA and converts it to string to display in the ListView
				item.SubItems.Add(nodeB.Value.ToString()); // adds nodeB value as subitems in listView
				listView.Items.Add(item); // Add items to listView to view 

				nodeA = nodeA.Next; // Advances the nodeA variable to the next node in the LinkedList
				nodeB = nodeB.Next;
			}
		}
		private void buttonIterativeA_Click(object sender, EventArgs e) // Button for IterativeA search
		{
			if (double.TryParse(textBoxSearchTargetA.Text, out double target)) // Parse search text box text to double called target
			{
				Stopwatch stopwatch = Stopwatch.StartNew(); // Start the stop watch to measure time lapsed
				List<double> valuesInRange = GetValuesWithinRange(sensorAData, target, 0.01); // Get values in range by calling method with parameters sensorA data, target number and range. 
				HighlightRange(listBoxSensorA, valuesInRange); // Call HighlightRange method with parameters, listBoxSensorA and valuesInRange
				stopwatch.Stop(); // Stop stopwatch
				textBoxIterativeA.Text = stopwatch.Elapsed.TotalMilliseconds.ToString("F2") + " ms"; // Put stopwatch results into textBoxIterativeA textbox
			}
			else
			{
				MessageBox.Show("Please enter valid numbers for target and range."); // If search target is not valid
			}
		}
		private List<double> GetValuesWithinRange(LinkedList<double> list, double target, double range) // GetValuesWithinRange method
		{
			var sortedList = list.ToList(); // Converts LinkedList<double> named list into List<double> and stores it in variable sortedList
			sortedList.Sort(); // sort sortedList
			return sortedList.Where(value => value >= target - range && value <= target + range).ToList(); // filters the sortedList to include only the values that fall within the range
		} // The returned list will contain all the elements from sortedList that are greater or equal to target - range less or equal to target + range

		private void HighlightRange(ListBox listBox, List<double> rangeValues)  // HighlightRange method
		{
			listBox.ClearSelected(); // Clear selections in the listBox

			for (int i = 0; i < listBox.Items.Count; i++) // Iterate over the listBox items
			{
				double itemValue = (double)listBox.Items[i]; // Retrieves the item at index i from ListBox and casts it to double, and then assigns it to variable itemValue
				if (rangeValues.Contains(itemValue)) // Checks the value itemValue is present in rangeValues
				{
					listBox.SetSelected(i, true); // Selects the item at index i in the ListBox
				}
			}
		}
		private void textBoxIterativeA_TextChanged(object sender, EventArgs e)
		{
		}
		private void buttonRecursiveA_Click(object sender, EventArgs e) // Button for Recursive A search
		{
			if (double.TryParse(textBoxSearchTargetA.Text, out double target)) // Parse text box text to double target
			{
				Stopwatch stopwatch = Stopwatch.StartNew(); // Start the stopwatch
				var sortedList = sensorAData.ToList(); // converts the LinkedList<double> named sensorAData into a List<double>
				sortedList.Sort(); // Sort the sortedList

				List<double> valuesInRange = RecursiveBinarySearch(sensorAData, target, 0.01, 0, sortedList.Count - 1); // calls the RecursiveBinarySearch method to find all values in sensorAData
				HighlightRange(listBoxSensorA, valuesInRange);																			// That fall within the range 
				stopwatch.Stop(); // Stop the stopwatch
				textBoxRecursiveA.Text = stopwatch.Elapsed.TotalMilliseconds.ToString("F2") + " ms"; // store stopwatch results in textboxRecursiveA
			}
			else
			{
				MessageBox.Show("Please enter valid numbers for target and range."); // If not a valid search
			}
		}
		private List<double> RecursiveBinarySearch(LinkedList<double> list, double target, double range, int low, int high) // this performs a recursive search through a portion of LinkedList<double> 
		{
			if (low > high) // If low greater than high
			{
				return new List<double>(); // Return list
			}

			int mid = (low + high) / 2; // Calculates the middle index of a sorted array
			var sortedList = list.ToList(); // Create new list from the existing collection 
			double midValue = sortedList[mid]; // Stores the value of a midValue in the list

			List<double> results = new List<double>(); // Creates a new instance of the list that will hold results

			if (midValue >= target - range && midValue <= target + range) // If midValue is greater or equal to target - range and midValue is less than or equal to target + range
			{
				results.Add(midValue); // Add results, argument midValue
				results.AddRange(RecursiveBinarySearch(list, target, range, low, mid - 1)); // Recursive binary search
				results.AddRange(RecursiveBinarySearch(list, target, range, mid + 1, high));
			}
			else if (midValue < target - range)
			{
				results.AddRange(RecursiveBinarySearch(list, target, range, mid + 1, high));
			}
			else
			{
				results.AddRange(RecursiveBinarySearch(list, target, range, low, mid - 1));
			}

			return results; // Final results for recursive binary search
		}
		private void textBoxRecursiveA_TextChanged(object sender, EventArgs e)
		{
		}
		private void textBoxSearchTargetA_TextChanged(object sender, EventArgs e)
		{
		}
		private void buttonSelectionSortA_Click(object sender, EventArgs e) // Button for selection sort for column A
		{
			Stopwatch stopwatch = Stopwatch.StartNew(); // Start stopwatch
			SelectionSort(sensorAData); // Call Selection sort with argument sensorAData
			FillListBoxWithSensorAData(); // Call Fill Listbox 
			stopwatch.Stop(); // Stop stopwatch
			textBoxSelectionSortA.Text = stopwatch.Elapsed.TotalMilliseconds.ToString("F2") + " ms"; // Fill timer data
		}
		private void SelectionSort(LinkedList<double> list) // Selection sort method
		{
			if (list.Count <= 1) return; // If list less or equal to 1

			LinkedListNode<double> current = list.First; // Initialize current as the first node in the list

			while (current != null)
			{
				LinkedListNode<double> minNode = current; // minNode takes value of current
				LinkedListNode<double> searchNode = current.Next; // searchNode takes the value of the next node in the list
				while (searchNode != null)
				{
					if (searchNode.Value < minNode.Value)
					{
						minNode = searchNode;
					}
					searchNode = searchNode.Next;
				}
				double temp = current.Value;
				current.Value = minNode.Value;
				minNode.Value = temp;
				current = current.Next;
			}
		}
		private void textBoxSelectionSortA_TextChanged(object sender, EventArgs e)
		{
		}
		private void buttonInsertionSortA_Click(object sender, EventArgs e) // Button for Insertion Sort A Sensor
		{
			Stopwatch stopwatch = Stopwatch.StartNew(); // Start stopwatch
			InsertionSort(sensorAData); // Call method with argument
			stopwatch.Stop(); // Stop stopwatch
			FillListBoxWithSensorAData(); // Fill list box with data
			textBoxInsertionSortA.Text = stopwatch.Elapsed.TotalMilliseconds.ToString("F2") + " ms"; // Record and display timer data
		}
		private void InsertionSort(LinkedList<double> list) // Method for Insertion Sort
		{
			if (list.Count <= 1) return;
			LinkedListNode<double> current = list.First;
			while (current != null)
			{
				LinkedListNode<double> next = current.Next;
				while (next != null)
				{
					if (next.Value < current.Value)
					{
						double temp = current.Value;
						current.Value = next.Value;
						next.Value = temp;
					}
					next = next.Next;
				}
				current = current.Next;
			}
		}
		private void textBoxInsertionSortA_TextChanged(object sender, EventArgs e)
		{
		}
		private void listBoxSensorA_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
		private void buttonIterativeB_Click(object sender, EventArgs e) // Button Iterative Search 
		{
			if (double.TryParse(textBoxSearchTargetB.Text, out double target))
			{
				Stopwatch stopwatch = Stopwatch.StartNew();
				List<double> valuesInRange = GetValuesWithinRange(sensorBData, target, 0.01);
				HighlightRange(listBoxSensorB, valuesInRange);
				stopwatch.Stop();
				textBoxIterativeB.Text = stopwatch.Elapsed.TotalMilliseconds.ToString("F2") + " ms";
			}
			else
			{
				MessageBox.Show("Please enter valid numbers for target and range.");
			}
		}
		private void textBoxIterativeB_TextChanged(object sender, EventArgs e)
		{
		}
		private void textBoxRecursiveB_TextChanged(object sender, EventArgs e)
		{
		}
		private void buttonRecursiveB_Click(object sender, EventArgs e) // Button Recursive Sort
		{
			if (double.TryParse(textBoxSearchTargetB.Text, out double target))
			{
				Stopwatch stopwatch = Stopwatch.StartNew();
				var sortedList = sensorBData.ToList();
				sortedList.Sort();

				List<double> valuesInRange = RecursiveBinarySearch(sensorBData, target, 0.01, 0, sortedList.Count - 1);
				HighlightRange(listBoxSensorB, valuesInRange);
				stopwatch.Stop();
				textBoxRecursiveB.Text = stopwatch.Elapsed.TotalMilliseconds.ToString("F2") + " ms";
			}
			else
			{
				MessageBox.Show("Please enter valid numbers for target and range.");
			}
		}
		private void textBoxSearchTargetB_TextChanged(object sender, EventArgs e)
		{
		}
		private void buttonSelectionSortB_Click(object sender, EventArgs e) // Button for Selection Sort 
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			SelectionSort(sensorBData);
			FillListBoxWithSensorBData();
			stopwatch.Stop();
			textBoxSelectionSortB.Text = stopwatch.Elapsed.TotalMilliseconds.ToString("F2") + " ms";
		}
		private void textBoxSelectionSortB_TextChanged(object sender, EventArgs e)
		{
		}
		private void buttonInsertionSortB_Click(object sender, EventArgs e) // Button for Insertion Sort
		{
			Stopwatch stopwatch = Stopwatch.StartNew();
			InsertionSort(sensorBData);
			stopwatch.Stop();
			FillListBoxWithSensorBData();
			textBoxInsertionSortB.Text = stopwatch.Elapsed.TotalMilliseconds.ToString("F2") + " ms";
		}
		private void textBoxInsertionSortB_TextChanged(object sender, EventArgs e)
		{
		}
		private void listBoxSensorB_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
