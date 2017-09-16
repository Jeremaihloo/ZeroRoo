<template>
  <div id="app">
    <div id="table-wrapper" class="ui">
      <vuetable ref="vuetable" :multi-sort="true" detail-row-component="my-detail-row" track-by="id" @vuetable:cell-clicked="onCellClicked" :api-mode="false" :data="agentData" :fields="fields" :sort-order="sortOrder" :css="css.table" pagination-path="" :per-page="3" @vuetable:pagination-data="onPaginationData" @vuetable:loading="onLoading" @vuetable:loaded="onLoaded">
        <template slot="actions" scope="props">
          <div class="table-button-container">
            <button class="btn btn-warning btn-sm" @click="editRow(props.rowData)">
              <span class="glyphicon glyphicon-pencil"></span> 编辑</button>&nbsp;&nbsp;
            <button class="btn btn-danger btn-sm" @click="deleteRow(props.rowData)">
              <span class="glyphicon glyphicon-trash"></span> 删除</button>&nbsp;&nbsp;
          </div>
        </template>
      </vuetable>
      <vuetable-pagination ref="pagination" :css="css.pagination" @vuetable-pagination:change-page="onChangePage"></vuetable-pagination>
    </div>

    <modal v-model="editOpen" title="编辑">
      <edit-form :data="editingData"></edit-form>
      <template slot="footer">
        <button class="btn btn-default" @click="editOpen=false">取消</button>
        <button class="btn btn-primary" @click="save">保存</button>
      </template>
    </modal>
  </div>
</template>

<script>
import moment from 'moment'
import Vuetable from 'vuetable-2/src/components/Vuetable'
import VuetablePagination from 'vuetable-2/src/components/VuetablePagination'
import EditForm from '@/components/EditForm'
import DetailRow from '@/components/DetailRow'
import Vue from 'vue'
Vue.component('my-detail-row', DetailRow)

export default {
  name: 'app',
  components: {
    Vuetable,
    'vuetable-pagination': VuetablePagination,
    EditForm,
    'my-detail-row': DetailRow
  },
  data () {
    return {
      editOpen: false,
      editingData: null,
      agentData: [
        {
          orderDate: '2017-08-14',
          name: 'lujiejie',
          brand: 'adidasi',
          style: 'woshikuanshi',
          color: 'red',
          size: 'xxl',
          count: '10',
          sale_price: '100',
          pay_status: 'weifu',
          issuance_at: '2017-04-10',
          received_at: '2017-08-14',
          take_at: '2017-09-10',
          address: '19hao',
          post_type: 'shentong',
          post_id: '201799888',
          mark: 'beizhu',
          post_person: 'lujiejie',
          get_price: '99'
        },
        {
          orderDate: '2017-08-14',
          name: 'lujiejie',
          brand: 'adidasi',
          style: 'woshikuanshi',
          color: 'red',
          size: 'xxl',
          count: '10',
          sale_price: '100',
          pay_status: 'weifu',
          issuance_at: '2017-04-10',
          received_at: '2017-08-14',
          take_at: '2017-09-10',
          address: '19hao',
          post_type: 'shentong',
          post_id: '201799888',
          mark: 'beizhu',
          post_person: 'lujiejie',
          get_price: '99'
        }
      ],
      fields: [
        {
          name: 'orderDate',
          title: '日期',
          sortField: 'orderDate'
          // callback: 'formatDate'
        },
        {
          name: 'name',
          title: '<span class="orange glyphicon glyphicon-user"></span> 姓名',
          sortField: 'name'
        },
        {
          name: 'brand',
          title: '品牌',
          sortField: 'brand'
        },
        {
          name: 'style',
          title: '款式',
          sortField: 'style'
        },
        {
          name: 'color',
          title: '颜色',
          sortField: 'gender'
        },
        {
          name: 'size',
          title: '尺码',
          sortField: 'gender'
        }, {
          name: 'count',
          title: '件数',
          sortField: 'gender'
        }, {
          name: 'sale_price',
          title: '售价',
          sortField: 'gender'
        },
        '__slot:actions'
      ],
      sortOrder: [
        { field: 'name', direction: 'asc' },
        { field: 'orderDate', direction: 'desc' },
        { field: 'name', direction: 'asc' }
      ],
      css: {
        table: {
          tableClass: 'table table-striped table-bordered table-hovered',
          loadingClass: 'loading',
          ascendingIcon: 'glyphicon glyphicon-chevron-up',
          descendingIcon: 'glyphicon glyphicon-chevron-down',
          handleIcon: 'glyphicon glyphicon-menu-hamburger'
        },
        pagination: {
          infoClass: 'pull-left',
          wrapperClass: 'vuetable-pagination pull-right',
          activeClass: 'btn-primary',
          disabledClass: 'disabled',
          pageClass: 'btn btn-border',
          linkClass: 'btn btn-border',
          icons: {
            first: '',
            prev: '',
            next: '',
            last: ''
          }
        }
      }
    }
  },
  computed: {
    /* httpOptions(){
      return {headers: {'Authorization': "my-token"}} //table props -> :http-options="httpOptions"
    }, */
  },
  created () {
    for (let index = 0; index < this.agentData.length; index++) {
      if (typeof this.agentData[index]['id'] === 'undefined') {
        this.agentData[index]['id'] = index
      }
    }
    this.agentData = Object.assign([], this.agentData)
    this.editingData = this.agentData[0]
  },
  methods: {
    formatDate (value, fmt = 'D MMM YYYY') {
      return (value == null)
        ? ''
        : moment(value, 'YYYY-MM-DD').format(fmt)
    },
    onPaginationData (paginationData) {
      this.$refs.pagination.setPaginationData(paginationData)
    },
    onChangePage (page) {
      this.$refs.vuetable.changePage(page)
    },
    editRow (rowData) {
      this.editOpen = true
      this.editingData = rowData
    },
    deleteRow (rowData) {
      alert('You clicked delete on' + JSON.stringify(rowData))
    },
    onLoading () {
      console.log('loading... show your spinner here')
    },
    onLoaded () {
      console.log('loaded! .. hide your spinner here')
    },
    onCellClicked (data, field, event) {
      console.log('cellClicked: ', field.name)
      this.$refs.vuetable.toggleDetailRow(data.id)
    },
    save () {
      this.$engine.call({
        Service: 'ZeroRoo.Apps.LaundryAgent',
        Data: this.editingData
      }, res => {
        this.editOpen = false
      })
    }
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}

.orange.glyphicon {
  color: orange;
}

th.sortable {
  color: #ec971f;
}
</style>
