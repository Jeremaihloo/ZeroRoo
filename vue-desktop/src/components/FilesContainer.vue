<<template>
  <draggable v-model="files" @start="drag=true" @end="drag=false">
    <div v-for="file in files">{{file.name}}</div>
  </draggable>
</template>

<script>
import Draggable from 'vuedraggable'

export default {
  components:{
    Draggable
  },
  mounted() {
    this.$engine.call({
      ServiceName: 'ZeroRoo.Docker.JsServices.MainAppService',
      Action: 'GetVersion',
      Data: null
    }, res => {
      console.log('ZeroRoo.Docker.JsService.MainAppService', 'GetVersion', res.Data)
    })
  },
  data() {
    return {
      files: [],
      drag: false
    }
  }
}
</script>

