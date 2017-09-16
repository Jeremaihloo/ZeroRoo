<template>
  <div class="hello">
    <HotTable :root="root" :settings="hotSettings"></HotTable>
  </div>
</template>

<script>
import HotTable from 'vue-handsontable-official'
export default {
  name: 'hello',
  data () {
    return {
      root: 'test-hot',
      excelData: [
        [
          'Task 33',
          'Michael',
          '',
          'New',
          '',
          '',
          false,
          0
        ],
        [
          'Task 12',
          'Samuel',
          '',
          'New',
          '',
          '',
          false,
          0
        ],
        [
          'Task 96',
          'Kate',
          '',
          'Accepted',
          '',
          '',
          false,
          0
        ],
        [
          'Task 16',
          'Chris',
          '',
          'Accepted',
          '',
          '',
          false,
          0
        ],
        [
          'Task 19',
          'Samuel',
          '',
          'In progress',
          '24/01/2017',
          '15/05/2017',
          false,
          0
        ],
        [
          'Task 29',
          'Omar',
          '',
          'In progress',
          '24/01/2017',
          '13/06/2017',
          true,
          10
        ],
        [
          'Task 92',
          'Ben',
          '',
          'In progress',
          '26/01/2017',
          '20/04/2017',
          false,
          40
        ],
        [
          'Task 02',
          'Omar',
          '',
          'In progress',
          '26/01/2017',
          '05/02/2017',
          false,
          50
        ],
        [
          'Task 88',
          'Monica',
          '',
          'In progress',
          '26/01/2017',
          '15/02/2017',
          false,
          70
        ],
        [
          'Task 89',
          'Samuel',
          '',
          'In progress',
          '01/02/2017',
          '07/03/2017',
          false,
          40
        ],
        [
          'Task 26',
          'Paul',
          '',
          'In progress',
          '01/02/2017',
          '22/04/2017',
          true,
          20
        ],
        [
          'Task 56',
          'Jessica',
          '',
          'In progress',
          '01/02/2017',
          '11/05/2017',
          true,
          30
        ],
        [
          'Task 06',
          'Michael',
          '',
          'In progress',
          '01/02/2017',
          '06/06/2017',
          true,
          7
        ],
        [
          'Task 01',
          'Chris',
          '',
          'Completed',
          '05/02/2017',
          '12/02/2017',
          false,
          100
        ],
        [
          'Task 09',
          'Samuel',
          '',
          'Completed',
          '06/02/2017',
          '20/02/2017',
          false,
          100
        ],
        [
          'Task 14',
          'Michael',
          '',
          'Completed',
          '06/02/2017',
          '30/03/2017',
          false,
          100
        ],
        [
          'Task 20',
          'Paul',
          '',
          'Completed',
          '07/02/2017',
          '09/02/2017',
          false,
          100
        ],
        [
          'Task 04',
          'Ben',
          '',
          'Completed',
          '08/02/2017',
          '04/04/2017',
          false,
          100
        ],
        [
          'Task 33',
          'Samuel',
          '',
          'Rejected',
          '',
          '',
          false,
          0
        ],
        [
          'Task 79',
          'Kate',
          '',
          'Rejected',
          '',
          '',
          false,
          0
        ]
      ],
      hotSettings: {
        height: 456,
        colWidths: 100,
        minCols: 26,
        minRows: 100,
        rowHeaders: true,
        colHeaders: [
          'Task',
          'Owner',
          'Team',
          'Status',
          'Start date',
          'End date',
          'At risk',
          '% complete'
        ],
        columns: [
          {
            type: 'date',
            dateFormat: 'MM/DD/YYYY',
            correctFormat: true,
            defaultDate: '01/01/1900',
            allowEmpty: false,
            // datePicker additional options (see https://github.com/dbushell/Pikaday#configuration)
            datePickerConfig: {
              // First day of the week (0: Sunday, 1: Monday, etc)
              firstDay: 0,
              showWeekNumber: true,
              numberOfMonths: 3,
              disableDayFn: function (date) {
                // Disable Sunday and Saturday
                return date.getDay() === 0 || date.getDay() === 6
              }
            }
          }
        ],
        columnSorting: true,
        filters: true,
        dropdownMenu: true,
        contextMenu: true,
        autoRowSize: true,
        manualColumnMove: true,
        manualRowMove: true,
        fillHandle: {
          autoInsertRow: false
        }
      }
    }
  },
  components: {
    HotTable
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1,
h2 {
  font-weight: normal;
}

ul {
  list-style-type: none;
  padding: 0;
}

li {
  display: inline-block;
  margin: 0 10px;
}

a {
  color: #42b983;
}
</style>
