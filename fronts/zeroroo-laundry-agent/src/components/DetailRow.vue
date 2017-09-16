
  <template>
  <div @click="onClick">
    <div class="inline field">
      <label>日期: </label>
      <span>{{rowData.orderDate}}</span>
    </div>
    <div class="inline field">
      <label>姓名: </label>
      <span>{{rowData.name}}</span>
    </div>
    <div class="inline field">
      <label>品牌: </label>
      <span>{{rowData.brand}}</span>
    </div>
    <div class="inline field">
      <label>款式: </label>
      <span>{{rowData.style}}</span>
    </div>
    <div class="inline field">
      <label>颜色: </label>
      <span>{{rowData.color}}</span>
    </div>
    <div class="inline field">
      <label>尺码: </label>
      <span>{{rowData.size}}</span>
    </div>
    <div class="inline field">
      <label>件数: </label>
      <span>{{rowData.count}}</span>
    </div>
    <div class="inline field">
      <label>售价: </label>
      <span>{{rowData.sale_price}}</span>
    </div>
    <div class="inline field">
      <label>付款情况: </label>
      <span>{{rowData.pay_status}}</span>
    </div>
    <div class="inline field">
      <label>发货日期: </label>
      <span>{{rowData.issuance_at}}</span>
    </div>
    <div class="inline field">
      <label>到货日期: </label>
      <span>{{rowData.received_at}}</span>
    </div>
    <div class="inline field">
      <label>取走日期: </label>
      <span>{{rowData.take_at}}</span>
    </div>
    <div class="inline field">
      <label>收货地址: </label>
      <span>{{rowData.address}}</span>
    </div>
    <div class="inline field">
      <label>快递: </label>
      <span>{{rowData.post_type}}</span>
    </div>
    <div class="inline field">
      <label>单号: </label>
      <span>{{rowData.post_id}}</span>
    </div>
    <div class="inline field">
      <label>备注: </label>
      <span>{{rowData.mark}}</span>
    </div>
    <div class="inline field">
      <label>发货人: </label>
      <span>{{rowData.post_person}}</span>
    </div>
    <div class="inline field">
      <label>成本: </label>
      <span>{{rowData.get_price}}</span>
    </div>
  </div>
</template>

  <script>
export default {
  props: {
    rowData: {
      type: Object,
      required: true
    },
    rowIndex: {
      type: Number
    }
  },
  created () {
    console.log('sfsfsdf')
  },
  methods: {
    onClick (event) {
      console.log('my-detail-row: on-click', event.target)
    }
  }
}
</script>